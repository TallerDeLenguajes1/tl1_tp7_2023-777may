namespace AdminPersonal{
    public enum cargos
    { 
        Auxiliar,
        Administrativo, 
        Ingeniero, 
        Especialista, 
        Investigador
        
    }
    public class Empleado
    {
        private string nombre="";
        private string apellido=""; 
        private DateTime fechaNacimiento;
        private char estadoCivil; 
        private char genero; 
        private DateTime fechaIngresoEmpresa; 
        private double sueldoBasico; 
        private cargos cargo;

        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public DateTime FechaNacimiento { get => fechaNacimiento;}
        public char EstadoCivil { get => estadoCivil;}
        public char Genero { get => genero; }
        public DateTime FechaIngresoEmpresa { get => fechaIngresoEmpresa;}
        public double SueldoBasico { get => sueldoBasico;}
        public cargos Cargo { get => cargo;}

        public Empleado(string nom, string ape, DateTime nac, char eCivil, char gen, DateTime fechaIngr, double sB, cargos car)
        {
            nombre = nom;
            apellido = ape;
            fechaNacimiento = nac;
            estadoCivil = eCivil;
            genero = gen;
            fechaIngresoEmpresa = fechaIngr;
            sueldoBasico = sB;
            cargo = car;
        }
        public int Antiguedad()
        {
            return DateTime.Now.Year-FechaIngresoEmpresa.Year;
        }
        public int Edad()
        {
            return DateTime.Now.Year-FechaNacimiento.Year;
        }
        public int aniosJubilacion()
        {
            if(Genero == 'M')
            {
                return 60 - Antiguedad();
            }else{
                return 65 - Antiguedad();
            }
        }
        public double salario()
        {
            double adicional = 0;
            if(Antiguedad() < 20)
            {
                adicional += SueldoBasico/100 * Antiguedad();
            }else{
                adicional += SueldoBasico/4;
            }
            if(Cargo == cargos.Ingeniero || Cargo == cargos.Especialista)
            {
                adicional *= 1.5;
            }
            if(EstadoCivil == 'C')
            {
                adicional += 15000;
            }
            return SueldoBasico + adicional;
        }
    }
}