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

    public override bool Equals(object obj)
    {
        //Check if the given object is valid or not. 
        if(obj == null){
            return false;
        } 
        //Verifying if both objects are the same type.
        if(this.GetType() != obj.GetType()){
            return false;
        }
        FacialFeatures compare = obj as FacialFeatures;

        return this.EyeColor == compare.EyeColor && this.PhiltrumWidth == compare.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
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

    public override bool Equals(object obj)
    {
        if(obj == null) return false; 
        if(this.GetType() != obj.GetType()) return false; 
        Identity compare = obj as Identity; 

        return this.Email == compare.Email && this.FacialFeatures.Equals(compare.FacialFeatures);

    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

public class Authenticator
{
    private Identity admin {get;}
    private Dictionary<String, Identity> user = new Dictionary<string, Identity>(); 
    public Authenticator(){
        this.admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    }

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Equals(admin);
    }

    public bool Register(Identity identity)
    {
        if(identity == null || user.ContainsKey(identity.Email)) return false; 
        
        user.Add(identity.Email, identity); 
        return true; 
    }

    public bool IsRegistered(Identity identity)
    {
        Identity check = user[identity.Email];
        if(check == null) return false; 
        return check.Equals(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA.GetHashCode == identityB.GetHashCode;   
    }
}
