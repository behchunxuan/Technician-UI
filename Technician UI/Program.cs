namespace Technician_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            //Application.Run(new Forgot_Password());
            //Application.Run(new Reset_Password());
            //Application.Run(new Technician_MainUI());
            //Application.Run(new ViewService());
            //Application.Run(new CustomerServiceDetails());
            //Application.Run(new Inbox());
            //Application.Run(new Email_Reading());
            //Application.Run(new Technician_Personal_Profile());
            //Application.Run(new VerifyYourself());
        }
    }
}