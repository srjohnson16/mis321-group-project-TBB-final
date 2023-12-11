namespace api.Database
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString(){
            string server = "acw2033ndw0at1t7.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "expzdr10nsjf6ytx";
            string port = "3306";
            string userName = "v629ni5hh21eubr0";
            string password = "w5o6ikn2vn62wtv8";

            //

            cs = $@"server = {server}; user ={userName}; database = {database}; port = {port}; password = {password};";
        }
    }
}