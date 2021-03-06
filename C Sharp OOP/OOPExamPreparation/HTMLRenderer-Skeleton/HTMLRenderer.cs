﻿using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.CSharp;

namespace HTMLRenderer
{
	public interface IElement
	{
		string Name { get; }
		string TextContent { get; set; }
		IEnumerable<IElement> ChildElements { get; }
		void AddElement(IElement element);
		void Render(StringBuilder output);
		string ToString();
	}

    public class HtmlElement : IElement
    {
        private ICollection<IElement> childElements;

        #region IElement Members

        public HtmlElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public HtmlElement(string name, string textContent)
            : this(name)
        {
            this.TextContent = textContent;
        }

        public string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public IEnumerable<IElement> ChildElements { get { return new List<IElement>(this.childElements); } }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {
                for (int i = 0; i < this.TextContent.Length; i++)
                {
                    char currentChar = this.TextContent[i];
                    switch (currentChar)
                    {
                        case '<':
                            output.Append("&lt;");
                            break;
                        case '>':
                            output.Append("&gt;");
                            break;
                        case '&':
                            output.Append("&amp;");
                            break;
                        default:
                            output.Append(currentChar);
                            break;
                    }
                }
            }

            foreach (var child in this.ChildElements)
            {
                output.Append(child.ToString());
            }

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        #endregion
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }    
    }

    public class HtmlTable : HtmlElement, ITable
    {
        private const string TableName = "table";

        private int rows;
        private int cols;
        private IElement[,] cells;

        public HtmlTable(int rows, int cols)
            :base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[rows, cols];
        }


        #region ITable Members

        public int Rows
        {
            get 
            { 
                return this.rows; 
            }

            private set
            {
                if (value <= 0) // TODO: check
                {
                    throw new ArgumentOutOfRangeException("Invalid rows");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get 
            { 
                return cols; 
            }

            private set
            {
                if (value <= 0) // TODO: check
                {
                    throw new ArgumentOutOfRangeException("Invalid cols");
                }

                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                this.ValidateIndecies(row, col);
                return this.cells[row, col];
            }
            set
            {
                this.ValidateIndecies(row, col);
                if (value == null)
                {
                    throw new ArgumentNullException("Value is null");
                }

                this.cells[row, col] = value;
            }
        }

        private void ValidateIndecies(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            if (col < 0 || col >= this.Cols)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
        }

        public override void AddElement(IElement element)
        {
            throw new NotSupportedException();
        }

        public override string TextContent
        {
            get
            {
                throw new NotSupportedException();
            }
            set
            {
                throw new NotSupportedException();
            }
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", HtmlTable.TableName);
            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    output.Append(this.cells[row, col]);
                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.AppendFormat("</{0}>", HtmlTable.TableName);
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }

	public interface ITable : IElement
	{
		int Rows { get; }
		int Cols { get; }
		IElement this[int row, int col] { get; set; }
	}

    public interface IElementFactory
    {
		IElement CreateElement(string name);
		IElement CreateElement(string name, string content);
		ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
		public IElement CreateElement(string name)
		{
            return new HtmlElement(name);
		}

		public IElement CreateElement(string name, string content)
		{
            return new HtmlElement(name, content);
		}

		public ITable CreateTable(int rows, int cols)
		{
            return new HtmlTable(rows, cols);
		}
	}

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
			string csharpCode = ReadInputCSharpCode();
			CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
