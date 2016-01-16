using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

[Table(Name="tUsers")]
public class entityUsers
{
    private string _username;
    private string _password;

    public entityUsers()
    {

    }

    public entityUsers(string u, string p)
    {
        Username = u;
        Password = p;
    }

    [Column(IsPrimaryKey = true, Storage ="_username")]
    public string Username
    {
        get
        {
            return _username;
        }
        set
        {
            _username = value;
        }
    }

    [Column(Storage="_password")]
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
        }
    }
}