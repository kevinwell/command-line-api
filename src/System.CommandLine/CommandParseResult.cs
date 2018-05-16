// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace System.CommandLine
{
    public class CommandParseResult : ParseResult
    {
        internal CommandParseResult(
            IReadOnlyCollection<string> tokens,
            SymbolSet symbols,
            ParserConfiguration configuration,
            IReadOnlyCollection<string> unparsedTokens = null,
            IReadOnlyCollection<string> unmatchedTokens = null,
            IReadOnlyCollection<ParseError> errors = null,
            string rawInput = null) : base(tokens, symbols, configuration, unparsedTokens, unmatchedTokens, errors, rawInput)
        {
        }
    }
}
