public class Login {
    private string loginEmail;
    private string loginPassword;
    public Login(string loginEmail,string loginPassword){
        this.loginEmail = loginEmail;
        this.loginPassword = loginPassword;
    }
    public string GetLoginEmail(){
        return this.loginEmail;
    }
    public string GetLoginPassword(){
        return this.loginPassword;
    }
}