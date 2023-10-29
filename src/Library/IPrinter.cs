namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
         void Print(IPrintable printable); //Para que no dependa de la clase recipe, ahora depende de IPrintable
    }
}