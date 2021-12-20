using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptionApp.Models {
    public class MorseAlgorithm : IEncrypt {
        public string InputString { get; set; }
        private string output = "";

        private static readonly Dictionary<char, string> alphabet = new() {
        { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." }, { 'E', "." }, { 'F', "..-." }, { 'G', "--." }, { 'H', "...." }, { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" },
        { 'L', ".-.." }, { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" }, { 'U', "..-" }, { 'V', "...-" },
        { 'W', ".--" }, { 'X', "-..-" }, { 'Y', "-.--" }, { 'Z', "--.." }, { ' ', "/" }, { '0', "-----" }, { '1', ".----" }, { '2', "..---" }, { '3', "...--" }, { '4', "....-" }, { '5', "....." }, { '6', "-...." },
        { '7', "--..." }, { '8', "---.." }, { '9', "----." }, { '.', ".-.-.-" }, { ',', "--..--" }, { '?', "..--.." }, { '!', "-.-.--" }, { '@', ".--.-." }
        };
        private readonly Dictionary<string, char> inversedAlphabet = alphabet.ToDictionary((i) => i.Value, (i) => i.Key); //switches Values with Keys in Dictionary.

        public string Crypt() {
            if (InputString[0] == '.' || InputString[0] == '-') {
                return Decipher();
            }
            else {
                return Cipher();
            }
        }
        public string Decipher() {
            string[] morseChars = InputString.Split(' '); //array of morse characters
            morseChars = morseChars.Where(x => !string.IsNullOrEmpty(x)).ToArray(); //removes null or empty values in array

            foreach (var key in morseChars) {
                output += inversedAlphabet[key];
            }
            return output;
        }
        public string Cipher() {
            foreach (char key in InputString.ToUpper()) {
                    output += alphabet[key] + " ";
            }
            return output;
        }
    }
}
