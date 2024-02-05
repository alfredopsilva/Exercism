using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
}

public class Authenticator
{
    private Identity admin {get;}
    private Dictionary<String, Identity> user = new Dictionary<string, Identity>(); 
    public Authenticator(){
        Identity admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    }

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return Object.Equals(faceA, faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return Object.Equals(admin, identity);
    }

    public bool Register(Identity identity)
    {
        if(identity == null || user.ContainsKey(identity.Email)) return false; 
        
        user.Add(identity.Email, identity); 
        return true; 
    }

    public bool IsRegistered(Identity identity)
    {
        return user.ContainsKey(identity.Email);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        throw new NotImplementedException("Please implement the Authenticator.AreSameObject() method");
    }
}
