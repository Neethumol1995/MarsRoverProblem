namespace MarsRoverProblem.Data.Constants
{
    // compass directions
    public enum Directions
    {
        
        // North
        N,
        // East
        E,
        // South
        S,
        // West
        W
    }

    //Extensions for Enums
    public static class EnumExtensions
    {
        public static T ToEnumValue<T>(this string value) where T : System.Enum
        {
            try
            {
                return (T)System.Enum.Parse(typeof(T), value);
            }
            catch
            {
                return default;
            }
        }
    }
}
