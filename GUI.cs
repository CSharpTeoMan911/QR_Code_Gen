namespace QR_Code_Gen
{
    class GUI
    {
        public enum InputType
        {
            URL,
            FilePath,
            FileName
        }

        public enum ErrorMessage
        {
            InvalidURL,
            InvalidFilePath,
            FileCreationError
        }
        
        protected static string? GetInput(InputType type)
        {
            try
            {
                Console.Clear();
            }
            catch{}

            switch(type)
            {
                case InputType.URL:
                    Console.Write("\n\nEnter URL to encode: ");
                    break;
                case InputType.FilePath:
                    Console.Write("\n\nEnter file path where the QR code will be stored: ");
                    break;
                case InputType.FileName:
                    Console.Write("\n\nEnter the file name of the QR code: ");
                    break;
            }

            return Console.ReadLine();
        }

        protected static void GetErrorMessage(ErrorMessage msg)
        {
            Console.Clear();
            switch(msg)
            {
                case ErrorMessage.InvalidURL:
                    Console.WriteLine("[ Invalid URL ]");
                    break;
                case ErrorMessage.InvalidFilePath:
                    Console.WriteLine("[ Invalid path ]");
                    break;
                case ErrorMessage.FileCreationError:
                    Console.WriteLine("[ QR file generation error ]");
                    break;
            }
            Console.ReadKey();
        }

        protected static void QRFileGenerationSuccessful()
        {
            Console.Clear();
            Console.WriteLine("[ File genearated successfuly ]");
            Console.ReadKey();
        }
    }
}