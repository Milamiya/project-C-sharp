package ketnoi;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.sql.*;

/**
 *
 * @author 10520_000
 */
public class DAO 
{
    public static ConnectUnit Connect;
    
    public static boolean Open(String host,String username,String password,String database, int port)
    {
         return   ((Connect =  new ConnectUnit(host, port, username, password, database))).Connect();
    }
     public static Connection getConnection(){
            
            return Connect.getConnectionReport();
    }
    public static void Close()
    {
        try 
        {
            Connect.Close();
        }
        catch (SQLException ex) 
        {
            Logger.getLogger(DAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public static ResultSet CallProc(String procName, List<String> param)
    {
        try 
        {
            String SPsql = "{ CALL  " + procName + "( ";   // for stored proc taking 2 parameters
            for(int i =0 ; i < param.size();i++)
                SPsql += " ?,";
            SPsql = SPsql.substring(0, SPsql.length()-1) + ")}";
            CallableStatement call = Connect._connect._connect.prepareCall(SPsql);
            call.setEscapeProcessing(true);
            call.setQueryTimeout(50);
            int index = 1;
            for(String s : param)
            {
                String[] spl = s.split(":");
                switch (spl[0])
                {
                    case "char":
                    case "nvarchar":
                        if(spl.length ==1 || spl[1] == null || spl[1].isEmpty())
                            if(spl[0].equals("char"))
                                call.setNull(index++, Types.CHAR);
                            else
                                call.setNull(index++, Types.NVARCHAR);
                        else
                            call.setString(index++, spl[1] );
                        break;
                    case "tinyint":
                    case "int":
                    case "smallint":
                        if(spl.length ==1 || spl[1] == null)
                            if(spl[0].equals("int"))
                                call.setNull(index++, Types.INTEGER);
                            else
                                call.setNull(index++, Types.SMALLINT);
                        else
                            call.setInt(index++,Integer.parseInt(spl[1]));
                        break;
                     case "money":
                          if(spl.length ==1 || spl[1] == null)
                                call.setNull(index++,Types.FLOAT);
                          else 
                              call.setFloat(index++, Float.parseFloat(spl[1]));
                        break;
                    case "bit":
                        if(spl.length == 1 || spl[1].equals("true"))
                            call.setBoolean(index++, true);
                        else
                            call.setBoolean(index++, false);
                        break;
                    case "Date":
                        if(spl.length == 1 || spl[1].isEmpty())
                            call.setNull(index++,Types.NULL);
                        else
                            call.setDate(index++, java.sql.Date.valueOf(spl[1]));
                        break;
                }
                    
            }
            return call.executeQuery();
        }
        catch (SQLException ex) 
        {
            Logger.getLogger(ConnectUnit.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    public static ResultSet CallProc(String procName)
    {
         try 
        {
            String SQL = "{CALL " + procName + "()}";
           CallableStatement call =  Connect._connect._connect.prepareCall(SQL);
           //exec [TimSach] '1', N'Vật Lý ', N'Vật Lý', null, 0, 600, 'OR' , 0
           return call.executeQuery();
        }
        catch (SQLException ex) 
        {
            Logger.getLogger(ConnectUnit.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    public static boolean CallProc(String procName, List<String> param, boolean Noreturn )
    {
        try 
        {
            String SPsql = "{ CALL  " + procName + "( ";   // for stored proc taking 2 parameters
            for(int i =0 ; i < param.size();i++)
                SPsql += " ?,";
            SPsql = SPsql.substring(0, SPsql.length()-1) + ")}";
            CallableStatement call = Connect._connect._connect.prepareCall(SPsql);
            call.setEscapeProcessing(true);
            call.setQueryTimeout(50);
            int index = 1;
            for(String s : param)
            {
                String[] spl = s.split(":");
                switch (spl[0])
                {
                    case "char":
                    case "nvarchar":
                        if(spl.length ==1 || spl[1] == null || spl[1].isEmpty())
                            if(spl[0].equals("char"))
                                call.setNull(index++, Types.CHAR);
                            else
                                call.setNull(index++, Types.NVARCHAR);
                        else
                            call.setString(index++, spl[1] );
                        break;
                    case "tinyint":
                    case "int":
                    case "smallint":
                        if(spl.length ==1 || spl[1] == null)
                            if(spl[0].equals("int"))
                                call.setNull(index++, Types.INTEGER);
                            else
                                call.setNull(index++, Types.SMALLINT);
                        else
                            call.setInt(index++,Integer.parseInt(spl[1]));
                        break;
                     case "money":
                          if(spl.length ==1 || spl[1] == null)
                                call.setNull(index++,Types.FLOAT);
                          else 
                              call.setFloat(index++, Float.parseFloat(spl[1]));
                        break;
                    case "bit":
                        if(spl.length == 1 || spl[1].equals("true"))
                            call.setBoolean(index++, true);
                        else
                            call.setBoolean(index++, false);
                        break;
                    case "Date":
                        if(spl.length == 1 )
                            call.setNull(index++, Types.DATE);
                        else
                            call.setDate(index++, new java.sql.Date(java.util.Date.parse(spl[1])));
                        break;
                }
                    
            }
            call.executeUpdate();
            return true;
        }
        catch (SQLException ex) 
        {
            Logger.getLogger(ConnectUnit.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
}
