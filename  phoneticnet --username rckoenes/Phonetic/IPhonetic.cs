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

namespace TripleSoftware.Phonetic
{
	/// <summary>
	/// interface for phonetic functions
	/// </summary>
	public interface IPhonetic
	{
		/// <summary>
		/// Generate a key accourding to the used algoritm
		/// </summary>
		/// <param name="strInput">String from whihch to calculate the key</param>
		/// <returns>Calculated key</returns>
		string GenerateKey( string strInput );
		
		/// <summary>
		/// Generate a key with a differnt key length than the deafult for the use algoritm
		/// </summary>
		/// <param name="strInput">String from whihch to calculate the key</param>
		/// <param name="keyLength">Length of the key to generate</param>
		/// <returns>Calculated key</returns>
		string GenerateKey( string strInput, int keyLength );
		
        /// <summary>
        /// Get the primary key
        /// </summary>
		string PrimaryKey{
			get;
		}
		
        /// <summary>
        /// Get the alternate key, if not present return the primary key
        /// </summary>
		string AlternateKey{
			get;
		}
	}
	
}
