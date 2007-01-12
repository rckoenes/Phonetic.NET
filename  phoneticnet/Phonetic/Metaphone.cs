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
	/// Metaphone phonetic algoritm.
    /// 
    /// Created by Lawrence Philips. Metaphone presented
    /// in article in "Computer Language" December 1990 issue.
	/// </summary>
	public class Metaphone : AMetaphone
	{
        /// <summary>
        /// generate a metaphone key for the given string
        /// Keylength is set to 4 as default for Metaphone
        /// </summary>
        /// <param name="strInput">String for which to compute the key</param>
        /// <returns>primary key</returns>
		public override string GenerateKey(string strInput)
		{
			return GenerateKey( strInput, 4 );
		}
         
        /// <summary>
        /// generate a metaphone key for the given string
        /// </summary>
        /// <param name="strInput">String for which to compute the key</param>
        /// <param name="keyLength">Length of the key to generate</param>
        /// <returns>primary key</returns>
		public override string GenerateKey(string strInput, int keyLength)
		{
			// reset the internal input string
			this.Reset();
			
			strInput = CheckInput( strInput);
			if( strInput == null )
				return primaryKey;
			

			if( Regex.IsMatch( strInput, "^KN|^GN|^PM|^AE|^WR" ) ){
				input = strInput.Substring( 1 );
			} else if( Regex.IsMatch( strInput, "^X" ) ){
				input = "S" + strInput.Substring( 1 );
			} else if( Regex.IsMatch( strInput, "^WH" ) ){
				input = "W" + strInput.Substring( 2 );
			} else{
				input = strInput;
			}

			//just to speed things up
			inputLength = input.Length;

			for( int i = 0; i < inputLength; i++){
                if (i != 0 && (input[i] == input[i-1]))
                    continue;
                switch( input[i] ){
					case 'A':
					case 'E':
					case 'I':
					case 'O':
					case 'U':
						if( i == 0 )
							AddToKey( input[i].ToString().ToUpper() );
						break;
					case 'F':
					case 'J':
					case 'L':
					case 'M':
					case 'N':
					case 'R':
                        AddToKey(input[i].ToString().ToUpper());
						break;
					case 'B':
						if( i != (inputLength -1 ) && !IsChar( i-1, 'M') )
							AddToKey( "B" );
						break;
					case 'C':
						HandleC(i);
						break;
					case 'D':
						if( IsChar(i+1,'G') && IsChar(i+2,'E','Y','I') )
							AddToKey("J");
						else
							AddToKey("T");
						break;
					case 'G':
						HandleG(i);
						break;
					case 'H':
						if( IsVowel( i+1 ) && !IsChar(i-1,'C','S','P','T','G') )
							AddToKey("H");
						break;
					case 'K':
						if( !IsChar( i-1, 'c') )
							AddToKey("K");
						break;
					case 'P':
						if( IsChar( i-1, 'H') )
							AddToKey("F");
						else
							AddToKey("P");
						break;
					case 'Q':
						AddToKey("K");
						break;
					case 'S':
						HandleS(i);
						break;
					case 'T':
						HandleT(i);
						break;
					case 'V':
						AddToKey("F");
						break;
					case 'W':
					case 'Y':
						if(IsVowel(i+1))
							AddToKey( input[i].ToString() );
						break;
					case 'X':
						AddToKey("KS");
						break;
					case 'Z':
						AddToKey("S");
						break;
				}
			}

			if( primaryKey.Length > keyLength)
				return primaryKey.Substring(0, keyLength);
			return primaryKey;
		}

		/// <summary>
		/// Complex letetr C routine
		/// </summary>
		/// <param name="i"></param>
		/// <returns>positon in the inputstring</returns>
		private void HandleC(int i)
		{
            if (IsChar(i-1,'s') && IsChar(i+1,'I','E','Y')) // sci, sce, scy
                return;
			if( IsMatch( i+1, "IA") ) // cia
				AddToKey( "X" );
            else if (!IsChar(i-1,'S') && IsChar(i+1,'H')  ) // ch but not sch
                AddToKey("X");
			else if ( IsChar(i+1,'I','E','Y') ) // ci, ce, cy
				AddToKey( "S" );
			else
			    AddToKey( "K" );
		}
		
		/// <summary>
		/// Complex letter G routine
		/// </summary>
        /// <param name="i">positon in the inputstring</param>
		private void HandleG(int i)
		{
				if( IsChar(i+1,'H') && !IsVowel(i+2) )
					return;
				if ( i > 0 ){
                    if ((i + 1 == (inputLength - 1) && IsChar(i + 1, 'N')) || //-gn
                        (i + 3 == (inputLength - 1) && IsMatch(i + 1, "NED"))) // -ned
                        return;
                    if ( IsChar(i - 1, 'D') && IsChar(i + 1, 'E', 'I', 'Y')) // -dge-, -dgi-, -dgy-
                        return;
                }
				if ( !IsChar(i-1,'G') && IsChar(i+1,'E','I','Y') )
					AddToKey("J");
				else
					AddToKey("K");
           
		}

		/// <summary>
		/// Handle the letetr S
		/// </summary>
        /// <param name="i">positon in the inputstring</param>
		private void HandleS(int i)
		{
			if ( IsChar(i+1,'H') ||
			    ( IsChar(i+1,'I') && IsChar(i+2,'O') ) ||
			    ( IsChar(i+1,'I') && IsChar(i+1,'A') ) ){
				AddToKey("X");
			} else{
				AddToKey("S");
			}
		}
		
        /// <summary>
        /// Handle the letter T
        /// </summary>
        /// <param name="i">positon in the inputstring</param>
		private void HandleT(int i){
            if( IsMatch(i, "TCH") )   // silent
                return;
			if( IsChar(i+1,'I') && ( IsChar(i+2,'A') || IsChar(i+2,'O') ) )
			   AddToKey("X");
			else if( IsChar(i+1,'H' ) )
				AddToKey("0");
			else 
                AddToKey("T");
		}
		
		/// <summary>
		/// Check wheter the char at the given postion is a vowel
        /// Vowels ar A,E,I,O,U
		/// </summary>
		/// <param name="pos">position in the input string</param>
		/// <returns>Vowel or not</returns>
		private bool IsVowel(int pos )
		{
			return IsChar( pos,'E','A','I','O','U');
		}
	}
}
