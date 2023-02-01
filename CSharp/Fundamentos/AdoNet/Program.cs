namespace AdoNet
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
            //Application.Run(new Form01PrimerAdo());
            //Application.Run(new Form02BuscadorEmpleados());
            //Application.Run(new Form03EliminarEnfermo());
            //Application.Run(new Form04ModificarSala());
            //Application.Run(new Form05DepartamentosEmpleados());
            //Application.Run(new Form06AccionDepartamento());
            //Application.Run(new Form07ProcedimientoUpdatePlantilla());
            //Application.Run(new Form08MensajesServidor());
            //Application.Run(new Form09ParametrosSalas());
            //Application.Run(new Form10HospitalEmpleados());
            //Application.Run(new Form11HospitalesEmpledosClases());
            Application.Run(new Form12EmpleadosOficios());

        }
    }
}