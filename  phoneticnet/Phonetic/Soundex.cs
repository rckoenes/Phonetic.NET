/*
 * Phonetic
 * Copyright (c) 2006, Triple Software
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, are 
 * permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice, this list 
 *   of conditions and the following disclaimer.
 * 
 * - Redistributions in binary form must reproduce the above copyright notice, this list
 *   of conditions and the following disclaimer in the documentation and/or other materials 
 *   provided with the distribution.
 * 
 * - Neither the name of the Triple Software nor the names of its contributors may be used to 
 *   endorse or promote products derived from this software without specific prior written 
 *   permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS &AS IS& AND ANY EXPRESS 
 * OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY 
 * AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
 * IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT 
 * OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
 
using System;
using System.Text.RegularExpressions;

namespace TripleSoftware.Phonetic
{
	/// <summary>
	/// Implementation of the Russel soundex
	/// </summary>
	public class Soundex : IPhonetic
	{
		string key = "";
		string input = "";

        /// <summary>
        /// generate a soundex key for the given string
        /// The key length is set to default of 4
        /// </summary>
        /// <param name="strInput">String for which to compute the key</param>
        /// <returns>primary key</returns>
		public string GenerateKey(string strInput)
		{
			return GenerateKey( strInput, 4);
		}

        /// <summary>
        /// generate a soundex key for the given string
        /// </summary>
        /// <param name="strInput">String for which to compute the key</param>
        /// <param name="keyLength">Length of the key to generate</param>
        /// <returns>primary key</returns>
		public string GenerateKey(string strInput, int keyLength)
		{
            // just check if the input string isn't empty 
            if (strInput.Equals(""))
                return "";
            
            // turn all leters in to Upper case
            input = strInput.ToUpper();
			// Replace non-chars with a white spcace
			input = Regex.Replace( input, "[^A-Z]", " ");
			// trim the string of any begining end eding white spaces
			input = input.Trim();

			// add the first leter to the key
			key = input.Substring(0, 1);
			
			// apply letter value
			input = Regex.Replace(input, "[AEIOUYHW]", "0");
      		input = Regex.Replace(input, "[BPFV]", "1");
      		input = Regex.Replace(input, "[CSGJKQXZ]", "2");
      		input = Regex.Replace(input, "[DT]", "3");
      		input = Regex.Replace(input, "[L]", "4");
      		input = Regex.Replace(input, "[MN]", "5");
      		input = Regex.Replace(input, "[R]", "6");

            // remove extra equal adjacent digits
            char LastChar = ' ';
            char CurChar = ' ';
            string TmpStr = "";
            for (int i = 0; i < input.Length; i++)
            {
                CurChar = input[i];
                if ( CurChar != LastChar)
                {
	                TmpStr += CurChar;
                }
                LastChar = CurChar;
            }

            input = TmpStr;


            //remove the first letter value
            input = input.Substring(1);
            //remove all zero's
            input = input.Replace("0", "");
      		// add zero's to fill minimum legth
            input = input.PadRight(keyLength,'0');
      		
      		key += input;
            return key.Substring(0, keyLength);

		}

        /// <summary>
        /// Get the primary key
        /// </summary>
		public string PrimaryKey {
			get {
				return key;
			}
		}

        /// <summary>
        /// Get the alternate key, if not present return the primary key
        /// </summary>
		public string AlternateKey {
			get {
				return key;
			}
		}
	}
}
