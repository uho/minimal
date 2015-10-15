\ Minimal Forth Workbench: testbench                                       uh 2015-10-25

: check ( "<space>filename" --)
   s" *minimal* marker *minimal*" EVALUATE ." ." include ;
 

include minimal.fs

primitive check
primitive marker    marker *minimal*

check stack.fs
check double.fs
check strings.fs
check arithmetic.fs
check control-structures.fs
check memory.fs
check compiling-words.fs
check defining-words.fs
check numeric-output.fs
check file-access.fs
check error-handling.fs

*minimal* 

\ -------------------------

include compiling-words.fs

cr .( All tests passed. )

bye