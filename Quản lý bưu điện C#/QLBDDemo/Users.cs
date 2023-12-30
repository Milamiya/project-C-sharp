using System.Security.Principal;
using System.Threading;
using System.IO;
using System;
using System.Data;
using System.Windows.Forms;

public class Users
{

    public bool IsLogin(string strName, string strPassword)
    {
        // Procedure checks that the login exists in the XML file

        DataSet dsUsers = new DataSet();
        DataRow[] drRows;
        bool ret = false;

        try
        {

            // Read the XML into a Dataset and filter on name and password
            // for a collection of DataRows.  This method is not case-sensitive            

            dsUsers.ReadXml(@"..\..\Users.xml");

            drRows = dsUsers.Tables[0].Select("name = '" +
                        strName + "' and password = '" + strPassword + "'");

            // Code must be implemented when adding users to the list to insure 
            // that there are no 2 users with the same name 
            // if there is a row in the collection then a record was found

            if (drRows.Length > 0)
            {

                ret = true;
            }
            else
            {
                ret = false;
            }

        }
        catch (FileNotFoundException)
        {
            MessageBox.Show("Users.Xml file not found.", "Unable to Authenticate user.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();

        }

        return ret;

    }

    public GenericPrincipal GetLogin(string strName, string strPassword)
    {
        // Procedure returns a Generic Principal representing the login account

        DataSet dsUsers = new DataSet();
        DataRow[] drRows = null;

        try
        {

            // Read the XML into a Dataset and filter for a collection of DataRows

            dsUsers.ReadXml(@"..\..\Users.xml");

            drRows = dsUsers.Tables[0].Select("name = '" +
                    strName + "' and password = '" + strPassword + "'");

        }
        catch (FileNotFoundException)
        {
            MessageBox.Show("Users.Xml file not found.", "Shutting Down...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();

        }

        // Create the Generic Identity representing the User

        GenericIdentity GenIdentity = new GenericIdentity(strName);

        // Define the role membership an array

        string[] Roles = { Convert.ToString(drRows[0]["Role"]), "" };
        GenericPrincipal GenPrincipal = new GenericPrincipal(GenIdentity, Roles);
        return GenPrincipal;

    }

    public bool IsAdministrator()
    {
        // Procedure checks if the Windows Login is an Administrator
        // For single role-based validation
        // WinPrincipal new WindowsPrincipal(WindowsIdentity.GetCurrent())
        // For repeated role-based validation

        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

        WindowsPrincipal WinPrincipal = (WindowsPrincipal)Thread.CurrentPrincipal;

        // Check if the user account is an Administrator

        if (WinPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
        {

            return true;
        }
        else
        {

            return false;

        }

    }

}

