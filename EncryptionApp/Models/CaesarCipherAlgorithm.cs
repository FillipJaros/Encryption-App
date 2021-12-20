using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptionApp.Models
{
    public class CaesarCipherAlgorithm : IEncrypt
    {
        public string InputString { get; set; }
        public int Shift { get; set; }
        public bool SwitchResult { get; set; }

        private int newShift;
        private string output = "";
        
        public string Crypt() {
            if (SwitchResult) {
                return Decipher();
            }
            else {
                return Cipher();
            }
        }
        public string Cipher() {
            foreach (char character in InputString) {
                if (char.IsUpper(character)) {
                    if (character != ' ') {
                        if (character + Shift > 90) {
                            newShift = Shift - 26;
                            output += Convert.ToChar(character + newShift);
                        }
                        else output += Convert.ToChar(character + Shift);
                    }
                    else output += ' ';
                }
                else {
                    if (character != ' ') {
                        if (character + Shift > 122) {
                            newShift = Shift - 26;
                            output += Convert.ToChar(character + newShift);
                        }
                        else output += Convert.ToChar(character + Shift);
                    }
                    else output += ' ';
                }
            }
            return output;
        }
        public string Decipher() {
            foreach (char character in InputString) {
                if (char.IsUpper(character)) {
                    if (character != ' ') {
                        if (character - Shift < 65) {
                            newShift = 26 - Shift;
                            output += Convert.ToChar(character + newShift);
                        }
                        else output += Convert.ToChar(character - Shift);
                    }
                    else output += ' ';
                }
                else {
                    if (character != ' ') {
                        if (character - Shift < 97) {
                            newShift = 26 - Shift;
                            output += Convert.ToChar(character + newShift);
                        }
                        else output += Convert.ToChar(character - Shift);
                    }
                    else output += ' ';
                }
            }
            return output;
        }
    }
}
