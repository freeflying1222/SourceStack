using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class OnlineAttribute : Attribute
    {
        public int Version { get; set; }
    }

    [Flags]
    enum Grade : short
    {
        Failed = 0,
        Passed = 1,
        Good = -1,
        Excellent = 3,
        //Garbage = -100
    }

    enum Role
    {
        TeamLeader = 1, //0001
        Expert = 2,     //0010
        Beauty = 4,     //0100
        Player = 8      //1000
        ///         -------
        ///         | 1111   (+)
        ///         & 0001   (-)
        ///           1110
        ///           

        ///   0010 
        ///   0010
        /// ^ -----
        ///   0000
        /// 


        ///  1011
        ///  0001
        ///&-----
        ///  0001
    }
}
