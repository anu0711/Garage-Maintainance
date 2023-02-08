using Garage_Management.Common.Interfaces;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class Blob:IBlob
    {
        public async Task<Uri> UploadImage(string filepath)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=uigmanagement;AccountKey=ruoXGGNxFMHoDJpGKsTbZ5masbenJds2dR8VQrFO7ikpVE9DXQ0dBS4rjC/DOZkAEVgaymiUV6N3+AStMs065Q==;EndpointSuffix=core.windows.net");

            // Create a blob client
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Get a reference to the container
            CloudBlobContainer container = blobClient.GetContainerReference("bills");

            // Create the container if it doesn't already exist
            container.CreateIfNotExistsAsync().GetAwaiter().GetResult();
            var name = Path.GetFileName(filepath);
            // Get a reference to the blob
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(name);

            // Read the image data from a local file
            using (var stream = new FileStream(filepath, FileMode.Open))
            {
                // Upload the data to the blob
                blockBlob.UploadFromStreamAsync(stream).GetAwaiter().GetResult();
            }
            return blockBlob.Uri;
        }
    }
}
