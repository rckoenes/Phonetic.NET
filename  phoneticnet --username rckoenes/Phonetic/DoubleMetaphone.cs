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
    /// Double Metaphone phonetic algoritm.
    /// 
    /// Created by Lawrence Philips. 
    /// Its implementation was described in the June 2000 issue of C/C++ Users Journal.
	/// </summary>
	public class DoubleMetaphone: AMetaphone
	{
        private bool slavoGermanic = false;

        /// <summary>
        /// Hase the input string Slavo or Germanic roots
        /// </summary>
        public bool IsSlavoGermanic
        {
            get
            {
                return slavoGermanic;
            }
        }

        /// <summary>
        /// Check if the input hase Slavo or Germanic roots
        /// </summary>
        private void SetSlavoGermanic()
        {
            if((input.IndexOf("W") != -1) || (input.IndexOf("K") != -1) ||
                (input.IndexOf("CZ") != -1) || (input.IndexOf("WITZ") != -1))
                slavoGermanic = true;
        }

        /// <summary>
        /// generate a double metaphone key for the given string
        /// Keylength is set to 4 as default for Metaphone
        /// </summary>
        /// <param name="strInput">String for which to compute the key</param>
        /// <returns>primary key</returns>
		public override string GenerateKey(string strInput)
		{
			return GenerateKey(strInput, 4);
		}

        /// <summary>
        /// generate a double metaphone key for the given string
        /// </summary>
        /// <param name="strInput">String for which to compute the key</param>
        /// <param name="keyLength">Length of the key to generate</param>
        /// <returns>primary key</returns>
        public override string GenerateKey(string strInput, int keyLength)
		{
			// reset all internal varibales
			Reset();
			
			strInput = CheckInput( strInput );
			if ( strInput == null )
				return primaryKey;
                        
            if (Regex.IsMatch(strInput, "^KN|^GN|^PM|^PS|^WR"))
                input += strInput.Substring(1);
            else if (Regex.IsMatch(strInput, "^X")){
                input += "S"+strInput.Substring(1);
            } else
                input += strInput;
           
            //just to speed things up
            inputLength = input.Length;
            
            SetSlavoGermanic();

            for( int i = 0; i < inputLength; i++ )
				switch( input[i] )
				{
					case 'A':
					case 'E':
					case 'I':
					case 'O':
					case 'U':
					case 'Y':
						if( i == 0 )
							AddToKey( "A" );
						break;
					case 'B':
                        // -umb is skipped over in M
						AddToKey("P");
						if( IsChar( i+1,'B') )
						   i++;
						break;
					case 'Ç':
              			AddToKey("S");
                		break;
					case 'C':
						i = HandleC(i);
						break;
                    case 'D':
                        i = HandleD(i);
                        break;
                    case 'F':
                        if (IsChar(i+1, 'F') )
                            i++;
                        AddToKey("F");
                        break;
                    case 'G':
                        i = HandleG(i);
                        break;
                    case 'H':
                        i = HandleH(i);
                        break;
                    case 'J':
                        i= HandleJ(i);
                        break;
                    case 'K':
                        if( IsChar( i+1, 'K') )
                            i++;
                        AddToKey("K");
                        break;
                    case 'L':
                        i = HandleL(i);
                        break;
                    case 'M':
                        i = HandleM(i);
                        break;
                    case 'N':
                        if( IsChar( i+1, 'N'))
                            i++;
                        AddToKey("N");
                        break;
                    case 'Ñ':
                        AddToKey("N");
                        break;
                    case 'P':
                        i=HandleP(i);
                        break;
                    case 'Q':
                        if( IsChar(i+1,'Q') )
                            i++;
                        AddToKey("K");
                        break;
                    case 'R':
                        i=HandleR(i);
                        break;
                    case 'S':
                        i=HandleS(i);
                        break;
                    case 'T':
                        i = HandleT(i);
                        break;
                    case 'V':
                        if(IsChar(i + 1,'V'))
                            i++;
                        AddToKey("F");
                        break;
                    case 'W':
                        i = HandleW(i);
                        break;
                    case 'X':
                        i = HandleX(i);
                        break;
                    case 'Z':
                        i = HandleZ(i);
                        break;
				}
			
            if( primaryKey.Length > keyLength )
				return primaryKey.Substring(0, keyLength);
			return primaryKey;
		}

        /// <summary>
        /// Handle the Z
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleZ(int i)
        {
            if(IsChar(i + 1,'H')) {
                AddToKey("J");
                return i + 1;
            } else if(IsMatch(i,"ZZO","ZZI","ZZA") ||
                        (IsSlavoGermanic && i > 0 && !IsChar(i - 1,'T')))
                AddToKey("S","TS");
            else
                AddToKey("S");

            if(IsChar(i + 1,'Z'))
                return i + 1;
            else
                return i;
                    
        }

        /// <summary>
        /// Handle the letetr X
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleX(int i)
        {
            if(!(i == (inputLength - 1) && (IsMatch(i - 3,"IAU","EAU") || IsMatch(i - 2,"AU","OU"))))
                AddToKey("KS");
            if(IsChar(i + 1,'X','C'))
                return i + 1;
            else
                return i;
        }

        /// <summary>
        /// Handle the letter W
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleW(int i)
        {
            if(IsChar(i + 1,'R')) {
                AddToKey("R");
                return i + 1;
            }

            if(i == 0 && (IsVowel(i + 1) || IsChar(i + 1,'H'))) {
                if(IsVowel(i + 1))
                    AddToKey("A","F");
                else
                    AddToKey("A");
            }

            if( ( i==(inputLength-1) &&IsVowel(i-1)) 
                    || IsMatch( i-1, "EWSKI", "EWSKY", "OWKSI","OWKSY")
                    || IsMatch( 0, "SCH") ){
                AddToKey("","F");
                return i;
            }

            if( IsMatch(i, "WICZ", "WITZ") ){
                AddToKey("TS", "FX" );
                return i+3;
            }

            return i;
        }

        /// <summary>
        /// Handle the letter T
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleT(int i)
        {
            if(IsMatch(i,"TION","TIA","TCH")) {
                AddToKey("X");
                return i + 2;
            }

            if(IsMatch(i,"TH","TTH")) {
                // thomas, thames
                if(IsMatch(i + 2,"OM","AM") || IsMatch(0,"VAN ","VON ","SCH"))
                    AddToKey("T");
                else
                    AddToKey("0","T");
                return i + 1;
            }
            
            AddToKey("T");
            if(IsChar(i+1, 'T','D') )
                return i+1;
            else
                return i;
        }

        /// <summary>
        /// Handle the letter S
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleS(int i)
        {
            // Silent s like in island, isle 
            if(IsMatch(i - 1,"ISL","YSL"))
                return i;

            if(i == 0 && IsMatch(i,"SUGAR")) {
                AddToKey("X","S");
                return i;
            }

            if(IsChar(i + 1,'H')) {
                if(IsMatch(i + 1,"HEIM","HOEK","HOLM","HOLZ"))
                    AddToKey("S");
                else
                    AddToKey("X");
                return i + 1;
            }

            if(IsMatch(i,"SIO","SIA","SIAN")) {
                if(IsSlavoGermanic)
                    AddToKey("S");
                else
                    AddToKey("S","X");
                return i + 2;
            }

            if((i == 0 && IsChar(i + 1,'M','N','L','W')) || IsChar(i + 1,'Z')) {
                AddToKey("S","X");
                if( IsChar(i+1,'Z') )
                    return i+1;
                else
                    return i;
            }

            if(IsChar(i+1,'C') ){
                if( IsChar( i+2, 'H') )
                    // Dutch school, schoon, scherm
                    if( IsMatch(i+3,"OO","ER","EN","UY","ED","EM")){
                        if(IsMatch(i + 3,"ER","EN")) // schenker, schermerhont
                            AddToKey("X","SK");
                        else
                            AddToKey("SK");
                        return i+2;
                    } else {
                       if( i==0 && !IsVowel(3) && !IsChar(3,'W') )
                           AddToKey("X","S");
                       else
                           AddToKey("X");
                        return i+2;
                    }

                if( IsChar(i+2,'I','E','Y')){
                    AddToKey("S");
                    return i+2;
                }
                    
                AddToKey("SK");
                return i+2;
            }

            if( 0 ==(inputLength-1) && IsMatch(i-2,"AI","OI"))
                AddToKey("","S");
            else
                AddToKey("S");

            if( IsChar( i+1, 'S','Z'))
                return i+1;
            else
                return i;
        }

        /// <summary>
        /// Handle the letter R
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleR(int i)
        {
            if(i == (inputLength - 1) && !IsSlavoGermanic && IsMatch(i - 2,"IE")
                    && !IsMatch(i - 4,"ME","MA"))
                AddToKey("","R");
            else
                AddToKey("R");

            if(IsChar(i + 1,'R'))
                return i + 1;
            else
                return i;
        }

        /// <summary>
        /// Handle the ltter R
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleP(int i)
        {
            if(IsChar(i + 1,'H')) {
                AddToKey("F");
                return i + 1;
            }

            AddToKey( "P" );
            if(IsChar(i + 1,'P','B'))
                return i + 1;
            else
                return i;
        }

        /// <summary>
        /// Handle the letter M
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleM(int i)
        {
            if((IsMatch(i - 1,"UMD") && (i == (inputLength - 1) || IsMatch(i + 2,"ER"))) )
                return i + 1;
            AddToKey("M");
            if(IsChar(i + 1,'M'))
                return i + 1;
            else
                return i;
        }

        /// <summary>
        /// Handle the letter L
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleL(int i)
        {
            if( IsChar(i+1,'L') ){
                // Spanish, cabrillo, gallegos
                if( ( i == (inputLength-3) && IsMatch( i-1, "ILLO", "ILLA", "ALLE")) ||
                     ((IsMatch(inputLength-2,"AS","OS") || IsChar(inputLength-1,'A','O' )) 
                        && IsMatch( i-1,"ALLE")) ){
                    AddToKey( "L", " ");
                    return i+1;
                } else
                    return i;
            } 

            AddToKey("L");
            return i;
        }

        /// <summary>
        /// Handle the letter J
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleJ(int i)
        {
            if(IsMatch(i,"JOSE","SAN")) {
                if((i == 0 && IsChar(i + 4,' ')) || IsMatch(0,"SAN "))
                    AddToKey("H");
                else
                    AddToKey("J","H");
                return i;
            } // Spanishe JOSE, SAN

            if(i == 0 && !IsMatch(i,"JOSE"))
                // Yankelovich/Jankelowicz
                AddToKey("J","A");
            else if(IsVowel(-1) && !IsSlavoGermanic && IsChar(i + 1,'A','O'))
                AddToKey("J","H"); //Spanish bajador
            else if(i == (inputLength - 1))
                AddToKey("J","");
            else if(!IsChar(i + 1,'L','T','K','S','N','M','B','Z')
                    && !IsChar(i - 1,'S','K','L'))
                AddToKey("J");
            
            if( IsChar(i+1, 'J') )
                return i+1;
            else
                return i;

        }

        /// <summary>
        /// Handle the letter H
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleH(int i)
        {
            if((i == 0 || IsVowel(i - 1)) && IsVowel(i + 1)) {
                AddToKey("H");
                return i + 1;
            } else
                return i;
        }

        /// <summary>
        /// Handle the letter G
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
        private int HandleG(int i)
        {
            if (IsChar(i + 1, 'H')) {
                if(i > 0 && !IsVowel(i - 1)) {
                    AddToKey("K");
                    return i + 1;
                }
                if(i==0) {
                    if(IsChar(i + 2, 'I'))
                        AddToKey("J");
                    else
                        AddToKey("K");
                    return i + 1;
                }
                if( (i>1 && IsChar(i-1,'B','H','D')) ||
                    (i>2 && IsChar(i-3,'B','H','D')) ||
                    (i>3 && IsChar(i-4,'B','H') ) )
                    return i+1;
                
                if( i>2 && IsChar(i-1,'U') && IsChar(i-3,'C','G','L','R','T'))
                    AddToKey("F");
                else if( i>0 && !IsChar(i-1,'I') )
                    AddToKey("K");
                return i+1;
            } // end GH
            
            if( IsChar(i+1,'N') ){
                if( i==1 && IsVowel(0) && IsSlavoGermanic )
                    AddToKey("KN","N");
                else if(!IsMatch(i+2,"ET") &&  !IsChar( i+1, 'Y') && IsSlavoGermanic)
                    AddToKey("KN");
                return i+1;
            }// end GN

            if( IsMatch( i, "GLI") && !IsSlavoGermanic ){
                AddToKey( "KL", "L" );
                return i+1;
            } // tagliaro

            if( i == 0 && (IsChar(i + 1,'y')
                || IsMatch(i + 1,"ES","EP","EB","EL","EY","IB","IL","IN","IE","EI","ER"))) {
                AddToKey("K","J");
                return i + 1;
            } // -ges-, -gep-, -gel-, -gie-

            if( (IsMatch(i + 1,"ER") || IsChar(i + 1,'Y'))
                && !IsMatch(0,"DANGER","RANGER","MANGER")
                && !IsChar(i + 1,'E','I') && !IsMatch(i + 1,"RGY","OGY")) {
                AddToKey("K","J");
                return i + 1;
            }//-ger-,-gy-

            if( IsChar( i+1,'E','I','Y') || IsMatch( i-1, "AGGI", "OGGI" ) ){
                if(IsMatch(0,"VAN ","VON ") || IsMatch(0,"SCH") || IsMatch(i,"GET"))
                    AddToKey("K");
                else if(IsMatch(i,"GIER"))
                    AddToKey("J");
                else
                    AddToKey("J","K");
                return i + 1;
            }// italian biaggi

            AddToKey("K");

            if(IsChar(i + 1,'G'))
                return i + 1;
            else
                return i;
        }

        /// <summary>
        /// Handle the letter D
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string></returns>
        private int HandleD(int i)
        {
            if( IsChar(i+1,'G') )
                if (IsChar(i + 2, 'I', 'E', 'Y')) // edge
                {
                    AddToKey("J");
                    return i + 2;
                }
                else  // edgar
                {
                    AddToKey("TK");
                    return i+1;
                }

            if (IsChar(i+1,'T', 'D'))
            {
                AddToKey("T");
                return i + 1;
            }

            AddToKey("T");
            return i;
        }
		
        /// <summary>
        /// Handle the letter C
        /// </summary>
        /// <param name="i">Currunt postion in the input string</param>
        /// <returns>new position in the string</returns>
		private int HandleC(int i)
		{

            // some germanic
            if( i > 1 && !IsVowel(i-2) && IsMatch(i-1,"ACH") && !IsChar(i+2,'I') && 
                ( !IsChar(i+2,'E') || IsMatch(i-2,"BACHER","MACHER") ) ) {
                AddToKey("K");
                i++;
                return i;
            }
            // caeser special 
            if (IsMatch(i, "CAESAR")){
                AddToKey("S");
                i++;
                return i;
            }
            // italian chaianti
            if (IsMatch(i, "CHIA"))
            {
                AddToKey("K");
                i++;
                return i;
            }

            if (IsChar(i + 1, 'H'))
            {
                if (i > 0 && IsMatch(i, "CHAE"))
                {
                    AddToKey("K", "X");
                    i++;
                    return i;
                }

                // words with greek roots
                if (i == 0 && (IsMatch(i, "CHARAC", "CHARIS", "HOR", "HYM", "HIA", "HEM")) 
                    && !IsMatch(i, "CHORE"))
                {
                    AddToKey("K");
                    return i+1;
                }

                // word with greek or germanic or ontherwide ch for kh
                if (IsMatch(0, "VAN ", "VON ", "SCH") ||
                    IsMatch(i - 2, "ORCHES", "ARCHIT", "ORCHID") ||
                    IsChar(i + 2, 'T', 'S') || 
                    ( (i == 0 || (IsChar(i - 1, 'A', 'O', 'U', 'E'))) &&
                        IsChar(i + 2, 'L', 'R', 'N', 'M', 'B', 'H', 'F', 'V', 'W', ' ')))
                    AddToKey("K");
                else
                    if (i == 0)
                        if (IsMatch(0, "MC")) //McDonalds
                            AddToKey("K");
                        else
                            AddToKey("X", "K");
                    else
                        AddToKey("X");
                return i+1;
            }
            
            if( IsChar(i+1,'Z') && !IsMatch( i-2,"WICZ") ){
                AddToKey( "S", "X" );
                return i+1;
            }

            if(IsMatch(i, "CIA")){
                AddToKey("x");
                return i+2;
            }

            if( IsChar( i+1,'C') && (!IsChar(0,'M') && i !=1) )
                if (IsChar(i + 2, 'I', 'E', 'H') && !IsMatch(i + 2, "HU"))
                {
                    if ((i == 1 && IsChar(i - 1, 'A')) || IsMatch(i - 1, "UCCEE") ||
                        IsMatch(i - 1, "UCCES"))
                        AddToKey("KS");
                    else
                        AddToKey("X");
                    return i + 2;
                }
                else
                { //Pierce's rule
                    AddToKey("K");
                    return i+1;
                }
            
            if (IsChar(i+1,'K','G','Q'))
            {
                AddToKey("K");
                return i+1;
            }

            if (IsChar(i + 1, 'I', 'E', 'Y') )
            {
                //italian vs. english
                if ( IsChar(i+1,'i') && IsChar( i+2,'O', 'E', 'A'))
                    AddToKey("S", "X");
                else
                    AddToKey("S");
                return i+1;
            }

            AddToKey("K");

            //'mac caffrey', 'mac gregor
            if (IsChar(i + 1, ' ') && IsChar(i + 2, 'C', 'Q', 'G'))
                i += 2;
            else
                if (IsChar(i + 1, 'C', 'K', 'Q') &&
                    !(IsMatch(i, "CCE") || IsMatch(i, "CCI")))
                    i++;
            return i;
		}

		/// <summary>
		/// Check if the letter at the given position is a vowel
        /// Vowels are E,A,I,O,U and Y
		/// </summary>
		/// <param name="i">position in input</param>
        /// <returns>Vowel or not</returns>
		private bool IsVowel( int i){
			return IsChar(i, 'E','A','I','O','U','Y' );
		}
	}
}
