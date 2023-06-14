using System;


namespace R5T.O0019
{
    public class CodeSyntaxGenerationOperations : ICodeSyntaxGenerationOperations
    {
        #region Infrastructure

        public static ICodeSyntaxGenerationOperations Instance { get; } = new CodeSyntaxGenerationOperations();


        private CodeSyntaxGenerationOperations()
        {
        }

        #endregion
    }
}
