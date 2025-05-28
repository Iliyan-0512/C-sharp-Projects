using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Task2.Helpers
{
    public static class CodeFormatter
    {
        public static string Format(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return "";

            code = ProtectControlStructures(code);

            var sb = new StringBuilder();
            int indentLevel = 0;
            bool newLine = true;
            bool insideString = false;

            foreach (char c in code)
            {
                switch (c)
                {
                    case '{':
                        sb.AppendLine();
                        sb.Append(new string(' ', indentLevel * 4));
                        sb.AppendLine("{");
                        indentLevel++;
                        newLine = true;
                        break;

                    case '}':
                        indentLevel = Math.Max(indentLevel - 1, 0);
                        sb.AppendLine();
                        sb.Append(new string(' ', indentLevel * 4));
                        sb.AppendLine("}");
                        newLine = true;
                        break;

                    case '"':
                        sb.Append('"');
                        insideString = !insideString;
                        break;

                    case ';':
                        sb.Append(';');
                        if (!insideString)
                        {
                            sb.AppendLine();
                            newLine = true;
                        }
                        break;

                    case ' ':
                        if (!newLine)
                            sb.Append(' ');
                        break;

                    default:
                        if (!char.IsWhiteSpace(c))
                        {
                            if (newLine)
                            {
                                sb.Append(new string(' ', indentLevel * 4));
                                newLine = false;
                            }
                            sb.Append(c);
                        }
                        break;
                }
            }

            var result = sb.ToString().Replace("##SEMICOLON##", ";");
            return result.Trim();
        }


        private static string ProtectControlStructures(string input)
        {
            var keywords = new[] { "for", "if", "while", "foreach", "switch", "catch", "using", "lock" };
            var result = new StringBuilder();
            int i = 0;

            while (i < input.Length)
            {
                bool matched = false;

                foreach (var keyword in keywords)
                {
                    if (input.Substring(i).StartsWith(keyword + " (") || input.Substring(i).StartsWith(keyword + "("))
                    {
                        int start = i;
                        int depth = 0;
                        bool foundParen = false;

                        while (i < input.Length)
                        {
                            char c = input[i];
                            if (c == '(')
                            {
                                depth++;
                                foundParen = true;
                            }
                            else if (c == ')')
                            {
                                depth--;
                                if (depth == 0 && foundParen)
                                {
                                    i++; // включи и последната ')'
                                    break;
                                }
                            }
                           
                            i++;
                        }

                        string block = input.Substring(start, i - start);
                        string protectedBlock = block.Replace(";", "##SEMICOLON##");
                        result.Append(protectedBlock);
                        matched = true;
                        break;
                    }
                }

                if (!matched)
                {
                    result.Append(input[i]);
                    i++;
                }
            }
            
            return result.ToString();
        }

    }
}
