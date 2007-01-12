/*
 * String Comapare
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
using System.Collections.Generic;
using System.Text;

namespace TripleSoftware.StringCompare
{
	/// <summary>
	/// Implementaion of the Levenshtein string distance algorithm
	/// </summary>
    public class Levenshtein : ALevenshtein
    {
		/// <summary>
		/// Calculate the distance between the strings using the Levenshtien algorithm
		/// </summary>
		/// <param name="orginale">Orginale srting</param>
		/// <param name="compare">String to whcih to compare the orginal</param>
		/// <returns>Distance between the strings</returns>
        public override int Compare(string orginale, string compare)
        {
            int[,] distance = new int[orginale.Length + 1, compare.Length + 1];
            int cost;

            // fill the string lenght in the matrix
            for (int i = 0; i <= orginale.Length; i++)
                distance[i, 0] = i;

            // fill the string lenght in the matrix
            for (int j = 0; j <= compare.Length; j++)
                distance[0, j] = j;

            for (int i = 1; i <= orginale.Length; i++)
                for (int j = 1; j <= compare.Length; j++)
                {
                    if (orginale[i - 1] == compare[j - 1])
                    {
                        cost = 0;
                    }
                    else
                    {
                        cost = 1;
                    }
                    distance[i, j] = Minimum(
                            distance[i - 1, j] + 1,        // deletion
                            distance[i, j - 1] + 1,       // insertion
                            distance[i - 1, j - 1] + cost   // substitution
                           );
                }
            return distance[orginale.Length, compare.Length];
        }


    }
}
