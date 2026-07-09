using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class clsPerson
    {
        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }

        protected clsPerson(int PersonID, string FirstName, string LastName, string Email, string Phone)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }
        protected clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
        }

    }
    public class clsClient : clsPerson
    {
        public string AccountNumber { set; get; }
        public int PinCode { set; get; }
        public float AccountBalance { set; get; }
        public int ClientID { set; get; }
        enum enMode
        {
            AddNew = 0,
            UpdateMode = 1
        }
        private enMode _Mode;
       private clsClient(int ClientID,int PersonID ,string FirstName, string LastName, string Email,
            string Phone, string AccountNumber,
            int PinCode, float AccountBalance) : base(PersonID,FirstName, LastName, Email, Phone)
        {
            this.ClientID = ClientID;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.AccountBalance = AccountBalance;
            this._Mode = enMode.UpdateMode;
        }
     public clsClient()
        {
            this.PersonID = -1;
            this.FirstName = "";
           this. LastName = "";
            this.Email = "";
            this.Phone = "";
           this. AccountNumber = "";
           this. PinCode = 0;
           this. AccountBalance = 0;
           this. _Mode = enMode.AddNew;
        }
        public static clsClient Find(string AccountNumber)
        {
            int personID=0,clientID=0, pinCode = 0;
            string firstName = "", lastName = "", email = "", phone = "";
            float accountBalance = 0;

            if (clsClientDataAccess.GetClient(ref clientID, AccountNumber,ref personID, ref firstName,
                ref lastName, ref email, ref phone, ref pinCode,
                ref accountBalance))
                return new clsClient(clientID,personID, firstName, lastName, email,
                   phone, AccountNumber, pinCode, accountBalance);
            else
                return null;
        }
        private bool _AddNewClient()
        {
            return clsClientDataAccess.AddNew(this.FirstName, this.LastName
                , this.Email, this.Phone, this.AccountNumber, 
                this.AccountBalance, this.PinCode);
        }
        private bool _UpdateClient()
        {
            return clsClientDataAccess.UpdateClient( this.FirstName
                , this.LastName, this.Email, this.Phone, this.AccountNumber,
                this.AccountBalance, this.PinCode,this.PersonID);
        }
     
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                        return false;
                    break;
                case enMode.UpdateMode:
                    if (_UpdateClient())
                        return true;
                    else
                        return false;
                    break;
            }
            return false;


        }
        public static  bool IsClientExists(string AccountNumber)
        {
            return clsClientDataAccess.IsClientExist(AccountNumber );
        }
        public static bool DeleteClient(string AccountNumber)
        {
            return clsClientDataAccess.DeleteClient(AccountNumber);
        }
        public static DataTable ListClients()
        {
            return clsClientDataAccess.ListClients();
        }
     
    }
    public class clsUser : clsPerson
    {
        public int UserID { set; get; }
        public string UserName { set; get; }
        public int Password { set; get; }
        public int Permission { set; get; }

        enum enMode
        {
            AddNew=0,
            Update=1
        }
        private enMode _Mode;
        
       private clsUser(string UserName,int Password,int Permission,int PersonID,int UserID,string FirstName,
          string LastName,string Eamil,string Phone):base(PersonID,FirstName ,LastName ,Eamil ,Phone )
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
            this._Mode = enMode.Update;
        }
       public clsUser()
        {
            this.UserName = "";
            this.Password = 0;
            this.Permission = 0;
            this._Mode = enMode.AddNew;
        }
      public static   clsUser Find(string UserName)
        {
            string firstName = "", lastName = "", email = "", phone = "";
            int personID=0,userID=0, password = 0, permission = 0;
            if ( clsUserDataAccess.GetUser(UserName,ref password,ref permission,ref personID,ref userID,ref firstName ,ref lastName, 
                ref email,ref phone))
                return new clsUser(UserName, password, permission,personID,userID,firstName,lastName,email,phone);
            else
               return  null;

        }
        private bool _AddNewUser()
        {
            return (clsUserDataAccess.AddNew(this.FirstName, this.LastName, this.Email,
                this.Phone, this.UserName, this.Password, this.Permission)) ;
        }
        private bool _UpdateUser()
        {
            return (clsUserDataAccess.UpdateUser(this.PersonID, this.FirstName,
                this.LastName, this.Email, this.Phone, this.Permission, this.Password));
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                    break;
                case enMode.Update:
                    if (_UpdateUser())
                        return true;
                    else
                        return false;
                    break;
            }
            return false;
        }
        public static bool IsUserExists(string UserName)
        {
            return clsUserDataAccess.IsUserExists(UserName);
        }
        public static bool DeleteUser(string UserName)
        {
            return clsUserDataAccess.DeleteUser(UserName);
        }
        public static DataTable ListUsers()
        {
           return  clsUserDataAccess.ListUsers();
        }

    }
    public class clsLogins
    {
        public int UserID { set; get; }
        public DateTime DateTime { set; get; }
        
       public  clsLogins()
        {
            UserID = 0;
            DateTime = DateTime.Now;
        }
        public bool AddNewLogin(int UserID)
        {
            return clsLoginsDataAccess.AddNewLogin(UserID );
        }
  
        public static DataTable ListLogins()
        {
            return clsLoginsDataAccess.ListLogins();
        }
    }
    public class clsTransactions
    {
        public int TransactionID { get; }
        public float Amount { set; get; }
        public int UserID { set; get; }
        public int FromAccountID { set; get; }
        public int ToAccountID { set; get; }
        public int TransactionTypeID { set; get; }
        public DateTime TransactionDate { set; get; }
        public clsTransactions()
        {
            TransactionID = 0;
            Amount = 0;
            UserID = 0;
            FromAccountID = 0;
            ToAccountID = 0;
            TransactionTypeID = 0;
            TransactionDate = DateTime.Now;
        }
       public static bool Deposit(string AccountNumber,float Amount)
        {
            return clsTranasactionDataAccess.Deposit(AccountNumber, Amount);
        }
        public static bool Withdraw(string AccountNumber,float Amount)
        {
            return clsTranasactionDataAccess.Withdraw(AccountNumber, Amount);
        }
        public static bool Transfer(string FromAccount,string ToAccount,float Amount)
        {
            return clsTranasactionDataAccess.Transfer(FromAccount, ToAccount, Amount);
        }
        static public bool AddNewTransaction(int UserID,float Amount,int FromAccountID
            ,int ToAccountID,int TransactionTypeID,DateTime TransactionDate)
        {
            return clsTranasactionDataAccess.AddNewTransaction( UserID, 
                Amount, FromAccountID, ToAccountID, 
                TransactionTypeID, TransactionDate);
        }
     
        public static DataTable ListTransactions()
        {
            return clsTranasactionDataAccess.ListTransactions();
        }
    }
    public class clsCurrencies
    {
        public string Country { set; get; }
        public string Code { set; get; }
        public string CurrencyName { set; get; }
        public float RateToUSD { set; get; }
       clsCurrencies (string Country,string Code,string CurrencyName,float RateToUSD)
        {
            this.Country = Country;
            this.Code = Code;
            this.CurrencyName = CurrencyName;
            this.RateToUSD = RateToUSD;
        }
        public static clsCurrencies FindByCode(string Code)
        {
            string Country = "", CurrencyName="";
            float RateToUSD = 0;
            if (clsCurrencyDataAccess.GetCurrencyByCode(Code, ref Country,ref CurrencyName,ref RateToUSD))
            return new clsCurrencies(Country, Code, CurrencyName, RateToUSD);
            else
                return null;
        }
        public static clsCurrencies FindByCountry(string Country)
        {
            string Code = "", CurrencyName = "";
            float RateToUSD = 0;
            if (clsCurrencyDataAccess.GetCurrencyByCountry(Country, ref Code, ref CurrencyName, ref RateToUSD))
                return new clsCurrencies(Country, Code, CurrencyName, RateToUSD);
            else
                return null;
        }
   static  public bool Update(float NewRate,string Code)
        {
            return clsCurrencyDataAccess.UpdateRate( NewRate,  Code);
        }
     
        public static float ConvertCurrencies(float Amount,string FromCurrency,string ToCurrency)
        {
            return clsCurrencyDataAccess.ConvertCurrencies(Amount, FromCurrency, ToCurrency); 
        }
        public static DataTable ListCurrencies()
        {
            return clsCurrencyDataAccess.ListCurrencies();
        }

    }
}
