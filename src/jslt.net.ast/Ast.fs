module Jslt.Net.AST.Core

type Ast =
  | Null
  | Boolean of bool
  | Number  of float
  | String  of string
  | Array   of Ast list
  | Object  of (string*Ast) list
