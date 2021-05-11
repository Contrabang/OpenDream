﻿namespace OpenDreamShared.Compiler {
    enum TokenType {
        //Base lexer
        Error,
        Warning,
        Unknown,
        Skip, //Internally skipped by the lexer

        //Text lexer
        Newline,
        EndOfFile,

        //DM Preprocessor
        DM_Preproc_ConstantString,
        DM_Preproc_Define,
        DM_Preproc_Else,
        DM_Preproc_EndIf,
        DM_Preproc_Error,
        DM_Preproc_Identifier,
        DM_Preproc_If,
        DM_Preproc_Ifdef,
        DM_Preproc_Ifndef,
        DM_Preproc_Include,
        DM_Preproc_Number,
        DM_Preproc_ParameterStringify,
        DM_Preproc_Punctuator,
        DM_Preproc_Punctuator_Comma,
        DM_Preproc_Punctuator_LeftBracket,
        DM_Preproc_Punctuator_LeftParenthesis,
        DM_Preproc_Punctuator_Period,
        DM_Preproc_Punctuator_RightBracket,
        DM_Preproc_Punctuator_RightParenthesis,
        DM_Preproc_String,
        DM_Preproc_TokenConcat,
        DM_Preproc_Undefine,
        DM_Preproc_Warning,
        DM_Preproc_Whitespace,

        //DM
        DM_And,
        DM_AndAnd,
        DM_AndEquals,
        DM_As,
        DM_Bar,
        DM_BarBar,
        DM_BarEquals,
        DM_Break,
        DM_Call,
        DM_Colon,
        DM_Comma,
        DM_Continue,
        DM_Dedent,
        DM_Del,
        DM_Do,
        DM_Else,
        DM_Equals,
        DM_EqualsEquals,
        DM_Exclamation,
        DM_ExclamationEquals,
        DM_Float,
        DM_For,
        DM_Goto,
        DM_GreaterThan,
        DM_GreaterThanEquals,
        DM_Identifier,
        DM_If,
        DM_In,
        DM_Indent,
        DM_RightShift,
        DM_RightShiftEquals,
        DM_Integer,
        DM_LeftBracket,
        DM_LeftCurlyBracket,
        DM_LeftParenthesis,
        DM_LeftShift,
        DM_LeftShiftEquals,
        DM_LessThan,
        DM_LessThanEquals,
        DM_List,
        DM_Minus,
        DM_MinusEquals,
        DM_MinusMinus,
        DM_Modulus,
        DM_ModulusEquals,
        DM_New,
        DM_Null,
        DM_Period,
        DM_Plus,
        DM_PlusEquals,
        DM_PlusPlus,
        DM_Proc,
        DM_Question,
        DM_RawString,
        DM_Resource,
        DM_Return,
        DM_RightBracket,
        DM_RightCurlyBracket,
        DM_RightParenthesis,
        DM_Semicolon,
        DM_Set,
        DM_Slash,
        DM_SlashEquals,
        DM_Spawn,
        DM_Star,
        DM_StarEquals,
        DM_StarStar,
        DM_Step,
        DM_String,
        DM_SuperProc,
        DM_Switch,
        DM_Tilde,
        DM_TildeEquals,
        DM_To,
        DM_Var,
        DM_While,
        DM_Whitespace,
        DM_Xor,
        DM_XorEquals,

        //DMF
        DMF_Anchor1,
        DMF_Anchor2,
        DMF_AutoFormat,
        DMF_BackgroundColor,
        DMF_Border,
        DMF_Browser,
        DMF_Button,
        DMF_ButtonType,
        DMF_Category,
        DMF_Child,
        DMF_Color,
        DMF_Comma,
        DMF_Command,
        DMF_Distort,
        DMF_Elem,
        DMF_Equals,
        DMF_False,
        DMF_FontFamily,
        DMF_FontSize,
        DMF_Icon,
        DMF_Info,
        DMF_Input,
        DMF_Integer,
        DMF_IsDefault,
        DMF_IsDisabled,
        DMF_IsPane,
        DMF_IsVert,
        DMF_IsVisible,
        DMF_Left,
        DMF_Macro,
        DMF_Main,
        DMF_Map,
        DMF_Menu,
        DMF_Name,
        DMF_None,
        DMF_Output,
        DMF_Pos,
        DMF_PushBox,
        DMF_Resource,
        DMF_Right,
        DMF_RightClick,
        DMF_SavedParams,
        DMF_Size,
        DMF_StatusBar,
        DMF_String,
        DMF_Sunken,
        DMF_Text,
        DMF_TextColor,
        DMF_True,
        DMF_Type,
        DMF_Window,
        DMF_X,
        DMF_ZoomMode
    }

    class Token {
        public TokenType Type;
        public string Text;
        public string SourceFile;
        public int Line, Column;
        public object Value;

        public Token(TokenType type, string text, string sourceFile, int line, int column, object value) {
            Type = type;
            Text = text;
            SourceFile = sourceFile;
            Line = line;
            Column = column;
            Value = value;
        }

        public override string ToString() {
            return Type + "(" + SourceFile + ":" + Line + ":" + Column + ", " + Text + ")";
        }
    }
}
