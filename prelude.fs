\ Minimal Forth Workbench - system configuration                                uh 2015-10-25

\ primitives

include secondaries.fs   \ Minimal Forth secondaries, defined in terms of others

include extensions.fs \ Minimal Forth extensions (emBitter/Hoffmann/Hoekstra/Ouwerkerk)
                      \ as used in embeddingForth

\ include stack.fs
\ include double.fs
\ include strings.fs
\ include arithmetic.fs
\ include control-structures.fs
\ include memory.fs
\ include compiling-words.fs
\ include defining-words.fs
\ include numeric-output.fs
\ include file-access.fs
\ include error-handling.fs
\ include interpretive-conditionals.fs
