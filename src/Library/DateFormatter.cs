namespace TestDateFormat;

/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
public class DateFormatter
{

    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// name="date">Una fecha en formato "dd/mm/yyyy".
    /// La fecha convertida al formato "yyyy-mm-dd".
    public static string ChangeFormat(string date)
    {
        if (date.Length != 10)
        {
            return string.Empty;
        }
        
        if (date[2] != '/' || date[5] != '/')
        {
            return string.Empty;
        }

        bool result = false;
        string[] components = date.Split('/');
        if (components.Length == 3)
        {
            int day;
            int month;
            int year;

            result = int.TryParse(components[0], out day) &&
                int.TryParse(components[1], out month) &&
                int.TryParse(components[2], out year) &&
                day >= 1 && day <= 31 &&
                month >= 1 && month <= 12;
            if (result == false)
            {
                return string.Empty;
            }
        }

        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
}