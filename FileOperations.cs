using System.Text;
using QRCoder;

namespace QR_Code_Gen
{
    class FileOperations : Validations
    {
        public byte[] GenerateQRCode(string? url)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        public async Task<bool> StoreQRCode(string? path, string? name, byte[] qr_code)
        {
            bool result = false;
            string file_format = ".png";

            if (path != null)
            {
                if (name != null)
                {
                    StringBuilder path_builder = new StringBuilder(path.Length + name.Length + file_format.Length + 1);
                    path_builder.Append(path);
                    if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows) == true)
                    {
                        path_builder.Append(@"\");
                    }
                    else
                    {
                        path_builder.Append("/");
                    }
                    path_builder.Append(name);
                    path_builder.Append(file_format);

                    string full_path = path_builder.ToString();


                    try
                    {
                        FileStream fs = File.Open(full_path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        try
                        {
                            await fs.WriteAsync(qr_code, 0, qr_code.Length);
                            await fs.FlushAsync();
                            fs?.Dispose();
                            result = true;
                        }
                        catch
                        {

                        }
                        finally
                        {
                            fs?.Dispose();
                        }
                    }
                    catch { }
                }
            }

            return result;
        }
    }
}