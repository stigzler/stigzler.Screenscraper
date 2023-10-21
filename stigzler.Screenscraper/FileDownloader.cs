using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stigzler.Screenscraper
{
    public class FileDownloader
    {
        private readonly HttpClient httpClient;
        private readonly SemaphoreSlim semaphore;
        private readonly int maxConcurrentDownloads;

        public FileDownloader(int maxConcurrentDownloads)
        {
            httpClient = new HttpClient();
            semaphore = new SemaphoreSlim(maxConcurrentDownloads);
            this.maxConcurrentDownloads = maxConcurrentDownloads;
        }

        public async Task DownloadFilesAsync(List<DownloadTask> downloadTasks)
        {

            var downloadTasksList = new List<Task>();

            foreach (var downloadTask in downloadTasks)
            {
                downloadTasksList.Add(DownloadFileAsync(downloadTask));
            }

            await Task.WhenAll(downloadTasksList);
        }

        private async Task DownloadFileAsync(DownloadTask downloadTask)
        {
            await semaphore.WaitAsync();

            try
            {
                using (var response = await httpClient.GetAsync(downloadTask.Url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();

                    using (var fileStream = new FileStream(downloadTask.DestinationPath, FileMode.Create, FileAccess.Write))
                    using (var contentStream = await response.Content.ReadAsStreamAsync())
                    {
                        await contentStream.CopyToAsync(fileStream);
                    }
                }
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
