namespace QR_Code_Gen
{
    class Validations
    {
        public async Task<bool> ValidateURL(string? url)
        {
            if (url != null)
            {
                try
                {
                    HttpClient client = new HttpClient(
                        new HttpClientHandler()
                        {
                            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                        })
                    {
                        BaseAddress = new Uri(url)
                    };

                    return await (await client.GetAsync("/")).Content.ReadAsStringAsync() != null;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ValidatePath(string? path)
        {
            if (System.IO.Path.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}