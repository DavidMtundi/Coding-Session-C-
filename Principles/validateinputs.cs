namespace TutorsEquity.Principles
{
    /// <summary>
    /// this is a class for validating inputs in the program
    /// </summary>
    class validateinputs
    {
        public static bool isvalidInt(string value)
        {
            int defaultvalue = 0;
            return int.TryParse(value, out defaultvalue);
        }
        public static bool isvalidString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            return true;
        }
    }
}
