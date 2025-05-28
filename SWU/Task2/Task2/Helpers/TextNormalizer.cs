using System.Text;
using System.Text.RegularExpressions;

namespace Task2.Helpers

{
    public static class TextNormalizer
    {
        /// <summary>
        /// Normalize the input text according to the specified rules.
        /// Returns the normalized text, or null if an error occurs (with errorMessage set).
        /// </summary>
        public static string Normalize(string input, out string errorMessage)
        {
            errorMessage = null;
            if (input == null) input = string.Empty;

            // 1. Validate skip region markers (---% and %---) for correctness
            bool skipOpen = false;
            int i = 0;
            while (i < input.Length)
            {
                if (input.Substring(i).StartsWith("---%"))

                {
                    if (skipOpen)
                    {
                        errorMessage = "Error: Skip region markers ('---%' and '%---') cannot be nested.";
                        return null;
                    }
                    skipOpen = true;
                    i += 4;  // jump past the '---%' marker
                    continue;
                }
                if (input.Substring(i).StartsWith("%---"))

                {
                    if (!skipOpen)
                    {
                        errorMessage = "Error: Skip region close marker '%---' found without a matching opening marker.";
                        return null;
                    }
                    skipOpen = false;
                    i += 4;  // jump past the '%---' marker
                    continue;
                }
                i++;
            }
            if (skipOpen)
            {
                // An opening marker was found without a closing marker
                errorMessage = "Error: A skip region marker '---%' is not closed.";
                return null;
            }

            // 2. Process the string, preserving skip regions
            StringBuilder output = new StringBuilder();
            int pos = 0;
            while (pos < input.Length)
            {
                // Find the next skip region start
                int startIndex = input.IndexOf("---%", pos);
                if (startIndex < 0)
                {
                    // No more skip markers; normalize the rest of the text outside skip regions
                    string outsideText = input.Substring(pos);
                    output.Append(NormalizeOutsideSegment(outsideText));
                    break;
                }

                // Normalize text before the skip region
                string outsideSegment = input.Substring(pos, startIndex - pos);
                output.Append(NormalizeOutsideSegment(outsideSegment));

                // Find the end of the skip region
                int endIndex = input.IndexOf("%---", startIndex + 4);
                // (The endIndex is guaranteed to exist here due to prior validation)
                if (endIndex < 0)
                {
                    // Safety check (should not happen because of validation)
                    errorMessage = "Error: A skip region is not closed properly.";
                    return null;
                }

                // Copy the entire skip region (including markers) unchanged
                string skipSegment = input.Substring(startIndex, (endIndex + 4) - startIndex);
                output.Append(skipSegment);

                // Move past this skip region and continue processing
                pos = endIndex + 4;
            }

            // 3. Return the assembled normalized text
            return output.ToString();
        }

        /// <summary>
        /// Apply normalization rules to a segment of text outside skip regions:
        /// - Replace ~ with _
        /// - Collapse consecutive identical characters
        /// - Convert ALL-CAPS words to Capitalized case
        /// </summary>
        private static string NormalizeOutsideSegment(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            var sb = new StringBuilder();
            char? lastAppended = null;

            foreach (char ch in text)
            {
                // Заменяме ~ с _
                char normalizedChar = (ch == '~') ? '_' : ch;

                // Премахваме повтарящи се символи
                if (lastAppended == null || normalizedChar != lastAppended)
                {
                    sb.Append(normalizedChar);
                    lastAppended = normalizedChar;
                }
            }

            string compressed = sb.ToString();

            // Преобразуване на изцяло главни думи в Capitalized формата им
            string result = Regex.Replace(compressed, @"(?<![a-zA-Z])[A-Z]{2,}(?![a-zA-Z])", match =>

            {
                string word = match.Value;
                return char.ToUpper(word[0]) + word.Substring(1).ToLower();
            });

            return result;
        }

    }
}
