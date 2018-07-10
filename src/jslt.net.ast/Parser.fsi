// Signature file for parser generated by fsyacc
module Jslt.Net.AST.Parser
type token = 
  | VARIABLE of (string)
  | PIDENT of (string)
  | IDENT of (string)
  | AS
  | IMPORT
  | DEF
  | FOR
  | SLASH
  | STAR
  | MINUS
  | PLUS
  | SMALLOREQ
  | SMALLER
  | BIGGER
  | BIGOREQ
  | UNEQUALS
  | EQUALS
  | ASSIGN
  | LET
  | RPAREN
  | LPAREN
  | ELSE
  | IF
  | EOF
  | DOT
  | AND
  | OR
  | FALSE
  | TRUE
  | RCURLY
  | LCURLY
  | COLON
  | COMMA
  | RBRACKET
  | LBRACKET
  | STRING of (string)
  | FLOAT of (float)
  | NULL
type tokenId = 
    | TOKEN_VARIABLE
    | TOKEN_PIDENT
    | TOKEN_IDENT
    | TOKEN_AS
    | TOKEN_IMPORT
    | TOKEN_DEF
    | TOKEN_FOR
    | TOKEN_SLASH
    | TOKEN_STAR
    | TOKEN_MINUS
    | TOKEN_PLUS
    | TOKEN_SMALLOREQ
    | TOKEN_SMALLER
    | TOKEN_BIGGER
    | TOKEN_BIGOREQ
    | TOKEN_UNEQUALS
    | TOKEN_EQUALS
    | TOKEN_ASSIGN
    | TOKEN_LET
    | TOKEN_RPAREN
    | TOKEN_LPAREN
    | TOKEN_ELSE
    | TOKEN_IF
    | TOKEN_EOF
    | TOKEN_DOT
    | TOKEN_AND
    | TOKEN_OR
    | TOKEN_FALSE
    | TOKEN_TRUE
    | TOKEN_RCURLY
    | TOKEN_LCURLY
    | TOKEN_COLON
    | TOKEN_COMMA
    | TOKEN_RBRACKET
    | TOKEN_LBRACKET
    | TOKEN_STRING
    | TOKEN_FLOAT
    | TOKEN_NULL
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_prog
    | NONTERM_value
    | NONTERM_object_fields
    | NONTERM_rev_object_fields
    | NONTERM_array_values
    | NONTERM_rev_values
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (Core.Ast option) 
