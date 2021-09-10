\ Minimal Forth Extensions (Bitter/Hoffmann/Hoekstra/Ouwerkerk) uh 2021-09-10

\ ---------------------------------------------------------------------------
\ String:
\ ---------------------------------------------------------------------------

primitive BL ( -- bl )
primitive SPACE ( -- )
primitive SPACES ( u -- )
primitive S" ( "ccc<quote>" -- ) ( -- c-addr u )
primitive ." ( "ccc<quote>" -- )
primitive CHAR ( "<spaces>name"-- char )
primitive [CHAR] ( C: "<spaces>name" -- ) ( -- char )
primitive TYPE ( addr len -- )
primitive CMOVE ( c-addr1 c-addr2 u -- )


\ ---------------------------------------------------------------------------
\ Stack:
\ ---------------------------------------------------------------------------

primitive 2DROP ( x1 x2 -- )
primitive 2DUP ( d1 -- d1 d1 )


\ ---------------------------------------------------------------------------
\ Number to string conversion:
\ ---------------------------------------------------------------------------

primitive <# ( -- )
primitive # ( d -- d' )
primitive #S  ( d -- d' )
primitive #> ( d -- c-addr len )
primitive HOLD ( c -- )
primitive SIGN ( n -- )
primitive .R ( n u -- )
primitive U.R ( u -- )
primitive . ( n -- )
primitive BASE ( -- addr )
primitive HEX ( -- )
primitive DECIMAL ( -- )


\ ---------------------------------------------------------------------------
\ Compiling:
\ ---------------------------------------------------------------------------

primitive POSTPONE ( <name> -- )
primitive IMMEDIATE ( -- )
primitive STATE ( -- addr )


\ ---------------------------------------------------------------------------
\ Memory:
\ ---------------------------------------------------------------------------

primitive HERE ( -- addr )
: CHERE ( -- addr ) HERE ;
primitive ALLOT ( n -- )
primitive FILL ( c-addr u c -- )


\ ---------------------------------------------------------------------------
\ Error Recovery:
\ ---------------------------------------------------------------------------

primitive CATCH ( i*x xt -- j*x 0 | i*x n )
primitive THROW ( i*x n -- i*x | j*x n )
primitive ABORT" ( f "ccc<quote>" -- )


\ ---------------------------------------------------------------------------
\ Arithmetic:
\ ---------------------------------------------------------------------------

primitive UM* ( u1 u2 -- ud )
primitive UM/MOD ( ud u1 -- u2 u3 )


\ ---------------------------------------------------------------------------
\ Miscellaneous:
\ ---------------------------------------------------------------------------

primitive LEAVE ( -- ) ( R: loop-sys -- )
primitive VALUE ( x <name> -- ) ( -- x )
primitive TO    ( i*x <name> -- )
primitive S>D   ( n -- d )

\ ---------------------------------------------------------------------------

CR S" Minimal Forth extensions" TYPE
