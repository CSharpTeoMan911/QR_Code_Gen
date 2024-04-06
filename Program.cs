using System.Reflection.Metadata;
using System.Text;
using System.Text.Encodings.Web;
using QRCoder;


namespace QR_Code_Gen
{
    class Program:GUI
    {
        private static FileOperations fileOperations = new FileOperations();

        private static void Main()
        {
            bool res = Init().Result;
        }

        private static async Task<bool> Init()
        {
            string? url = GetInput(InputType.URL);
            if(await fileOperations.ValidateURL(url) == true)
            {
                string? path = GetInput(InputType.FilePath);
                if(fileOperations.ValidatePath(path) == true)
                {
                    await fileOperations.StoreQRCode(path, GetInput(InputType.FileName), fileOperations.GenerateQRCode(url));
                    QRFileGenerationSuccessful();
                }
                else
                {
                    GetErrorMessage(ErrorMessage.InvalidFilePath);
                }
            }
            else
            {
                GetErrorMessage(ErrorMessage.InvalidURL);
            }

            await Init();
            return true;
        }
    }
}
