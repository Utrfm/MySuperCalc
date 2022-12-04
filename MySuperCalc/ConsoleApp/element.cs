using ConsoleCalc;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleCalc
{
	public struct Element
	{
        public int type;
        public double value;

		//public Element()
		//{
		//	this.Type = type;
		//	this.value = value;
		//}
	}

    public enum ElementType: int
    {
        Number,
        Add,
        Sub,
        Div,
        Multiply,
        Sin,
        Cos
    }

}