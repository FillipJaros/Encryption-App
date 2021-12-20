namespace EncryptionApp.Models {
    public interface IEncrypt {
        string InputString { get; set; }

        string Cipher();
        string Crypt();
        string Decipher();
    }
}