namespace SteamSharp.Entities.Parameters
{
    public class BaseParameter(string parameterName, string parameterValue)
    {
        public string ParameterName => parameterName;

        public string ParameterValue => parameterValue;

        public override string ToString() => $"&{ParameterName}={ParameterValue}";
    }
}
