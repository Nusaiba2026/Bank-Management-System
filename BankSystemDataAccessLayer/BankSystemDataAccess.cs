using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class clsClientDataAccess
    {
        static public bool GetClient( ref int clientID,string AccountNumber,ref int personID,  ref string firstName,
                 ref string lastName, ref string email, ref string phone,
                  ref int pinCode, ref float accountBalance)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select Persons.PersonID,ClientID,FirstName,LastName,Email," +
                "Phone,PinCode,AccountBalance from " +
                "Persons\r\ninner join Clients \r\non Persons.PersonID=Clients.PersonID where Clients.AccountNumber=@AccountNumber" +
                "";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    personID = (int)reader["PersonID"];
                    clientID = (int)reader["ClientID"];
                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    pinCode = (int)reader["PinCode"];
                    accountBalance = (float)Convert.ToDecimal(reader["AccountBalance"]);

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;

            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
       public static bool AddNew(string FirstName,string LastName,string Email
         ,string Phone,string AccountNumber,float AccountBalance,int PinCode )
        {
            int clientID = -1;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "insert into Persons\r\n(FirstName,LastName," +
                "Email,Phone)\r\nvalues\r\n(@FirstName,@LastName,@Email," +
                "@Phone);\r\ninsert into Clients\r\n(PersonID,AccountNumber" +
                ",AccountBalance,PinCode)\r\nvalues\r\n" +
                "((select SCOPE_IDENTITY()),@AccountNumber,@AccountBalance," +
                "@PinCode);\r\n\r\nselect SCOPE_IDENTITY();\r\n";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    clientID = ID;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (clientID != -1);
        }
        public static bool UpdateClient(string FirstName,string LastName,
            string Email,string Phone,string AccountNumber,float AccountBalance,
            int PinCode,int PersonID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "update Persons " +
                "set FirstName=@FirstName,LastName=@LastName,Email=@Email,Phone=@Phone where PersonID=@PersonID;" +
                "update Clients " +
                "set AccountNumber=@AccountNumber ,PinCode=@PinCode,AccountBalance=@AccountBalance where PersonID=@PersonID;";
           
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected != 0);
        }
       public static bool IsClientExist(string AccountNumber)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select * from Clients where AccountNumber=@AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsExists = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsExists;
        }
        public static bool DeleteClient(string AccountNumber)
        {
            int rowAffectd = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "declare @PersonID int;\r\nset @PersonID=" +
                "(select PersonID from Clients where AccountNumber=@AccountNumber)" +
                "\r\nDelete from Clients where AccountNumber=@AccountNumber;\r\ndelete " +
                "from Persons where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                rowAffectd = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffectd != 0);
        }
        public static DataTable ListClients()
        {
            DataTable dtClients = new DataTable();
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select FirstName,LastName,Email,Phone,AccountNumber" +
                ",PinCode,AccountBalance from Clients inner join Persons on " +
                "Persons.PersonID=Clients.PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dtClients.Load(reader);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtClients;
        }
    }


    public class clsUserDataAccess
    {
        public static bool GetUser(string UserName,ref int Password,ref int Permission,ref int PersonID,ref int UserID,ref string FirstName,
            ref string LastName,ref string Email,ref string Phone)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select UserName,Persons.PersonID,UserID,Password,FirstName,LastName" +
                ",Email,Phone,Permission from Users\r\ninner join Persons \r\non " +
                "Persons.PersonID=Users.PersonID where UserName=@UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Password = (int)reader["Password"];
                    Permission = (int)reader["Permission"];
                    PersonID = (int)reader["PersonID"];

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool AddNew(string FirstName,string LastName,string Email,
            string Phone,string UserName,int Password,int Permission)
        {
            int userID = -1;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "insert into Persons\r\n(FirstName,LastName,Email,Phone)" +
                "\r\nvalues\r\n(@FirstName,@LastName,@Email,@Phone);\r\ninsert into Users" +
                "\r\n\r\n(PersonID,UserName,Password,Permission)\r\nvalues\r\n((select " +
                "SCOPE_IDENTITY()),@UserName,@Password,@Permission);" +
                "\r\nselect SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result !=null&&int.TryParse (result .ToString (),out int ID))
                {
                    userID = ID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (userID != -1);
        }
        public static bool UpdateUser(int PersonID,string FirstName,
            string LastName,string Email,string Phone,int Permission,
            int Password)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "update Persons set FirstName=@FirstName,LastName=" +
                "@LastName,Email=@Email,Phone=@Phone where PersonID=@PersonID;" +
                "update Users set Password=@Password," +
                "Permission=@Permission where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Permission", Permission);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected != 0);
        }
        public static bool IsUserExists(string UserName)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "SELECT*\r\nFROM Users\r\nWHERE UserName COLLATE Latin1_General_CS_AS = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsExists = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsExists;
        }
        public static bool DeleteUser(string UserName)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "declare @PersonID int;\r\nset @PersonID=(select" +
                " PersonID from Users where UserName=@UserName);\r\ndelete from Users " +
                "where UserName=UserName;\r\ndelete from Persons where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected!=0);
        }
        public static DataTable ListUsers()
        {
            DataTable dtUsers = new DataTable();
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select FirstName,LastName,Email,Phone,UserName," +
                "Permission,Password from Users inner join Persons on Persons." +
                "PersonID=Users.PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dtUsers.Load(reader);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtUsers;
        }

    }
    public class clsLoginsDataAccess
    {
public static bool AddNewLogin(int UserID)
        {
            int loginID = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "insert into Logins(UserID,DateTime)\r\nvalues" +
                "(@UserID,GETDATE())\r\nselect SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@DateTime", DateTime.Now);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(int.TryParse(result.ToString(), out int insertedID)){
                    loginID  = insertedID;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (loginID != 0);
        }
        public static DataTable ListLogins()
        {
            DataTable dtLogins = new DataTable();
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select UserName,DateTime from Users inner join " +
                "Logins on Users.UserID=Logins.UserID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dtLogins.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtLogins;
        }
    }
  public  class clsTranasactionDataAccess
    {
        public static bool AddNewTransaction(int UserID,float Amount,int FromAccID,
            int ToAccID,int TransTypeID,DateTime TransDate)
        {
            int TransactionID = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "\r\ninsert into Transactions\r\n(UserID,Amount" +
                ",FromAccount,ToAccount,TransactionType ,TransactionDate)" +
                "\r\nvalues\r\n(@UserID,@Amount,@FromAccount,@ToAccount," +
                "@TransType,@DateTime)\r\nselect " + "SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Amount", Amount);
            if (FromAccID != 0)
                command.Parameters.AddWithValue("@FromAccount", FromAccID);
            else
                command.Parameters.AddWithValue("@FromAccount", System.DBNull.Value);
            if (ToAccID != 0)
                command.Parameters.AddWithValue("@ToAccount", ToAccID);
            else
                command.Parameters.AddWithValue("@ToAccount", System.DBNull.Value);
            command.Parameters.AddWithValue("@TransType", TransTypeID);
            command.Parameters.AddWithValue("@DateTime", DateTime.Now);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(int .TryParse (result .ToString (),out int insertedID))
                {
                    TransactionID = insertedID;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (TransactionID != 0);
        }
        public static bool Deposit(string AccountNumber,float Amount)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "update Clients set AccountBalance=AccountBalance+" +
                "@Amount where AccountNumber=@AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected != 0);
        }



        public static bool Withdraw(string AccountNumber,float Amount)
        {
            int rowAffected = -1;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "if((select AccountBalance from Clients where" +
                " AccountNumber=@AccountNumber)>@Amount) update Clients " +
                "set AccountBalance=AccountBalance-@Amount where " +
                "AccountNumber=@AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected !=-1);
        }
        public static bool Transfer(string FromAccount,string ToAccount,float Amount)
        {
            int rowAffected = -1;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "if((select AccountBalance from Clients where " +
                "AccountNumber=@FromAccount)>@Amount)\r\n begin update Clients\r" +
                "\nset AccountBalance=AccountBalance+@Amount where" +
                " AccountNumber=@ToAccount \r\nupdate Clients\r\nset " +
                "AccountBalance=AccountBalance-@Amount where" +
                " AccountNumber=@FromAccount end";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FromAccount", FromAccount);
            command.Parameters.AddWithValue("@ToAccount", ToAccount);
            command.Parameters.AddWithValue("@Amount", Amount);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected!=-1);
        }
        public static DataTable ListTransactions()
        {
            DataTable dtTransactions = new DataTable();
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select * from Transactions";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dtTransactions.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtTransactions;
        }
    }
    public class clsCurrencyDataAccess
    {
        public static bool GetCurrencyByCode(string Code,ref string Country,ref string CurrencyName,ref float RateToUSD)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select * from Currencies where Code=@Code ";
            SqlCommand commmand = new SqlCommand(query, connection);
            commmand.Parameters.AddWithValue("@Code", Code);
            try
            {
                connection.Open();
                SqlDataReader reader = commmand.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    Country = (string)reader["Country"];
                    CurrencyName = (string)reader["CurrencyName"];
                    RateToUSD = Convert .ToSingle ( reader["RateToUSD"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool GetCurrencyByCountry(string Country, ref string Code, ref string CurrencyName, ref float RateToUSD)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select * from Currencies where Country=@Country";
            SqlCommand commmand = new SqlCommand(query, connection);
            commmand.Parameters.AddWithValue("@Country", Country );
            try
            {
                connection.Open();
                SqlDataReader reader = commmand.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    Code = (string)reader["Code"];
                    CurrencyName = (string)reader["CurrencyName"];
                    RateToUSD = Convert.ToSingle(reader["RateToUSD"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool UpdateRate(float NewRate,string Code)
        {
            int rowAffectd = 0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "update Currencies set RateToUSD=@NewRate " +
                "where Code =@Code ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewRate", NewRate);
            command.Parameters.AddWithValue("@Code", Code);
            try
            {
                connection.Open();
                rowAffectd = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffectd != 0);
        }
        public static float ConvertCurrencies(float Amount,string FromCurrency,string ToCurrency)
        {
            float Result=0;
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select @Amount*(select 1/RateToUSD" +
                " from Currencies where Code=@FromCurrencyCode)*" +
                "(select RateToUSD from Currencies where Code=" +
                "@ToCurrencyCode)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@FromCurrencyCode", FromCurrency);
            command.Parameters.AddWithValue("@ToCurrencyCode", ToCurrency);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(float.TryParse (result .ToString (),out float convertedAmount))
                {
                    Result = convertedAmount;
                }
              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Result;
        }
        public static DataTable ListCurrencies()
        {
            DataTable dtCurrencies = new DataTable();
            SqlConnection connection = new SqlConnection(clsBankSystemDataAccessSettings.ConnectionString);
            string query = "select * from Currencies";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dtCurrencies.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCurrencies;
        }
    }

    } 



