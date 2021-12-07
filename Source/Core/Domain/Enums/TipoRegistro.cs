namespace Domain.Enums
{
    /// <summary>
    /// Enumeración utilizada para especificar si un registro es de entrada, salida o un break 
    /// y por lo consiguiente asignar un controlingreso solo al registro de entrada
    /// Break hace referencia a una salida inesperada y que debe quedar como constancia
    /// </summary>
    public enum TipoRegistro
    {
        Entrada,
        Salida,
        Break
    }
}