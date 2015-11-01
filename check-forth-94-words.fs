\ Check Forth-94 words defined

\ get-order

\ get-order forth-wordlist swap 1+ set-order

: Forth-94: ( <name> -- )
     BL WORD DUP FIND NIP 0= IF CR COUNT TYPE ."  is undefined." ELSE DROP THEN  POSTPONE \ ;

\ set-order 

include minimal.fs
primitive Forth-94:

Forth-94: !           store                 CORE

Forth-94: #           number-sign           CORE
Forth-94: #>          number-sign-greater   CORE
Forth-94: #S          number-sign-s         CORE
Forth-94: #TIB        number-t-i-b          CORE EXT

Forth-94: '           tick                  CORE

Forth-94: (           paren                 FILE
Forth-94: (           paren                 CORE
Forth-94: (LOCAL)     paren-local-paren     LOCAL

Forth-94: *           star                  CORE
Forth-94: */          star-slash            CORE
Forth-94: */MOD       star-slash-mod        CORE

Forth-94: +           plus                  CORE
Forth-94: +!          plus-store            CORE
Forth-94: +LOOP       plus-loop             CORE

Forth-94: ,           comma                 CORE

Forth-94: -           minus                 CORE
Forth-94: -TRAILING   dash-trailing         STRING

Forth-94: .           dot                   CORE
Forth-94: ."          dot-quote             CORE
Forth-94: .(          dot-paren             CORE EXT
Forth-94: .R          dot-r                 CORE EXT
Forth-94: .S          dot-s                 TOOLS

Forth-94: /           slash                 CORE
Forth-94: /MOD        slash-mod             CORE
Forth-94: /STRING     slash-string          STRING

Forth-94: 0<          zero-less             CORE
Forth-94: 0<>         zero-not-equals       CORE EXT
Forth-94: 0=          zero-equals           CORE
Forth-94: 0>          zero-greater          CORE EXT

Forth-94: 1+          one-plus              CORE
Forth-94: 1-          one-minus             CORE

Forth-94: 2!          two-store             CORE
Forth-94: 2*          two-star              CORE
Forth-94: 2/          two-slash             CORE
Forth-94: 2>R         two-to-r              CORE EXT
Forth-94: 2@          two-fetch             CORE
Forth-94: 2CONSTANT   two-constant          DOUBLE
Forth-94: 2DROP       two-drop              CORE
Forth-94: 2DUP        two-dupe              CORE
Forth-94: 2LITERAL    two-literal           DOUBLE
Forth-94: 2OVER       two-over              CORE
Forth-94: 2R>         two-r-from            CORE EXT
Forth-94: 2R@         two-r-fetch           CORE EXT
Forth-94: 2ROT        two-rote              DOUBLE EXT
Forth-94: 2SWAP       two-swap              CORE
Forth-94: 2VARIABLE   two-variable          DOUBLE

Forth-94: :           colon                 CORE
Forth-94: :NONAME     colon-no-name         CORE EXT

Forth-94: ;           semicolon             CORE
Forth-94: ;CODE       semicolon-code        TOOLS EXT

Forth-94: <           less-than             CORE
Forth-94: <#          less-number-sign      CORE
Forth-94: <>          not-equals            CORE EXT

Forth-94: =           equals                CORE

Forth-94: >           greater-than          CORE
Forth-94: >BODY       to-body               CORE
Forth-94: >FLOAT      to-float              FLOATING
Forth-94: >IN         to-in                 CORE
Forth-94: >NUMBER     to-number             CORE
Forth-94: >R          to-r                  CORE

Forth-94: ?           question              TOOLS
Forth-94: ?DO         question-do           CORE EXT
Forth-94: ?DUP        question-dupe         CORE

Forth-94: @           fetch                 CORE

Forth-94: ABORT                             CORE
Forth-94: ABORT                             EXCEPTION EXT
Forth-94: ABORT"      abort-quote           CORE
Forth-94: ABORT"      abort-quote           EXCEPTION EXT
Forth-94: ABS         abs                   CORE
Forth-94: ACCEPT                            CORE
Forth-94: AGAIN                             CORE EXT
Forth-94: AHEAD                             TOOLS EXT
Forth-94: ALIGN                             CORE
Forth-94: ALIGNED                           CORE
Forth-94: ALLOCATE                          MEMORY
Forth-94: ALLOT                             CORE
Forth-94: ALSO                              SEARCH EXT
Forth-94: AND                               CORE
Forth-94: ASSEMBLER                         TOOLS EXT
Forth-94: AT-XY       at-x-y                FACILITY

Forth-94: BASE                              CORE
Forth-94: BEGIN                             CORE
Forth-94: BIN                               FILE
Forth-94: BL          b-l                   CORE
Forth-94: BLANK                             STRING
Forth-94: BLK         b-l-k                 BLOCK
Forth-94: BLOCK                             BLOCK
Forth-94: BUFFER                            BLOCK
Forth-94: BYE                               TOOLS EXT

Forth-94: C!          c-store               CORE
Forth-94: C"          c-quote               CORE EXT
Forth-94: C,          c-comma               CORE
Forth-94: C@          c-fetch               CORE
Forth-94: CASE                              CORE EXT
Forth-94: CATCH                             EXCEPTION
Forth-94: CELL+       cell-plus             CORE
Forth-94: CELLS                             CORE
Forth-94: CHAR        char                  CORE
Forth-94: CHAR+       char-plus             CORE
Forth-94: CHARS       chars                 CORE
Forth-94: CLOSE-FILE                        FILE
Forth-94: CMOVE       c-move                STRING
Forth-94: CMOVE>      c-move-up             STRING
Forth-94: CODE                              TOOLS EXT
Forth-94: COMPARE                           STRING
Forth-94: COMPILE,    compile-comma         CORE EXT
Forth-94: CONSTANT                          CORE
Forth-94: CONVERT                           CORE EXT
Forth-94: COUNT                             CORE
Forth-94: CR          c-r                   CORE
Forth-94: CREATE                            CORE
Forth-94: CREATE-FILE                       FILE
Forth-94: CS-PICK     c-s-pick              TOOLS EXT
Forth-94: CS-ROLL     c-s-roll              TOOLS EXT

Forth-94: D+          d-plus                DOUBLE
Forth-94: D-          d-minus               DOUBLE
Forth-94: D.          d-dot                 DOUBLE
Forth-94: D.R         d-dot-r               DOUBLE
Forth-94: D0<         d-zero-less           DOUBLE
Forth-94: D0=         d-zero-equals         DOUBLE
Forth-94: D2*         d-two-star            DOUBLE
Forth-94: D2/         d-two-slash           DOUBLE
Forth-94: D<          d-less-than           DOUBLE
Forth-94: D=          d-equals              DOUBLE
Forth-94: D>F         d-to-f                FLOATING
Forth-94: D>S         d-to-s                DOUBLE
Forth-94: DABS        d-abs                 DOUBLE
Forth-94: DECIMAL                           CORE
Forth-94: DEFINITIONS                       SEARCH
Forth-94: DELETE-FILE                       FILE
Forth-94: DEPTH                             CORE
Forth-94: DF!         d-f-store             FLOATING EXT
Forth-94: DF@         d-f-fetch             FLOATING EXT
Forth-94: DFALIGN     d-f-align             FLOATING EXT
Forth-94: DFALIGNED   d-f-aligned           FLOATING EXT
Forth-94: DFLOAT+     d-float-plus          FLOATING EXT
Forth-94: DFLOATS     d-floats              FLOATING EXT
Forth-94: DMAX        d-max                 DOUBLE
Forth-94: DMIN        d-min                 DOUBLE
Forth-94: DNEGATE     d-negate              DOUBLE
Forth-94: DO                                CORE
Forth-94: DOES>       does                  CORE
Forth-94: DROP                              CORE
Forth-94: DU<         d-u-less              DOUBLE EXT
Forth-94: DUMP                              TOOLS
Forth-94: DUP         dupe                  CORE

Forth-94: EDITOR                            TOOLS EXT
Forth-94: EKEY        e-key                 FACILITY EXT
Forth-94: EKEY>CHAR   e-key-to-char         FACILITY EXT
Forth-94: EKEY?       e-key-question        FACILITY EXT
Forth-94: ELSE                              CORE
Forth-94: EMIT                              CORE
Forth-94: EMIT?       emit-question         FACILITY EXT
Forth-94: EMPTY-BUFFERS                     BLOCK EXT
Forth-94: ENDCASE     end-case              CORE EXT
Forth-94: ENDOF       end-of                CORE EXT
Forth-94: ENVIRONMENT ?environment-query    CORE
Forth-94: ERASE                             CORE EXT
Forth-94: EVALUATE                          CORE
Forth-94: EVALUATE                          BLOCK
Forth-94: EXECUTE                           CORE
Forth-94: EXIT                              CORE
Forth-94: EXPECT                            CORE EXT

Forth-94: F!          f-store               FLOATING
Forth-94: F*          f-star                FLOATING
Forth-94: F**         f-star-star           FLOATING EXT
Forth-94: F+          f-plus                FLOATING
Forth-94: F-          f-minus               FLOATING
Forth-94: F.          f-dot                 FLOATING EXT
Forth-94: F/          f-slash               FLOATING
Forth-94: F0<         f-zero-less-than      FLOATING
Forth-94: F0=         f-zero-equals         FLOATING
Forth-94: F<          f-less-than           FLOATING
Forth-94: F>D         f-to-d                FLOATING
Forth-94: F@          f-fetch               FLOATING
Forth-94: FABS        f-abs                 FLOATING EXT
Forth-94: FACOS       f-a-cos               FLOATING EXT
Forth-94: FACOSH      f-a-cosh              FLOATING EXT
Forth-94: FALIGN      f-align               FLOATING
Forth-94: FALIGNED    f-aligned             FLOATING
Forth-94: FALOG       f-a-log               FLOATING EXT
Forth-94: FALSE                             CORE EXT
Forth-94: FASIN       f-a-sine              FLOATING EXT
Forth-94: FASINH      f-a-cinch             FLOATING EXT
Forth-94: FATAN       f-a-tan               FLOATING EXT
Forth-94: FATAN2      f-a-tan-two           FLOATING EXT
Forth-94: FATANH      f-a-tan-h             FLOATING EXT
Forth-94: FCONSTANT   f-constant            FLOATING
Forth-94: FCOS        f-cos                 FLOATING EXT
Forth-94: FCOSH       f-cosh                FLOATING EXT
Forth-94: FDEPTH      f-depth               FLOATING
Forth-94: FDROP       f-drop                FLOATING
Forth-94: FDUP        f-dupe                FLOATING
Forth-94: FE.         f-e-dot               FLOATING EXT
Forth-94: FEXP        f-e-x-p               FLOATING EXT
Forth-94: FEXPM1      f-e-x-p-m-one         FLOATING EXT
Forth-94: FILE-POSITION                     FILE
Forth-94: FILE-SIZE                         FILE
Forth-94: FILE-STATUS                       FILE EXT
Forth-94: FILL                              CORE
Forth-94: FIND                              CORE
Forth-94: FIND                              SEARCH
Forth-94: FLITERAL    f-literal             FLOATING
Forth-94: FLN         f-l-n                 FLOATING EXT
Forth-94: FLNP1       f-l-n-p-one           FLOATING EXT
Forth-94: FLOAT+      float-plus            FLOATING
Forth-94: FLOATS                            FLOATING
Forth-94: FLOG        f-log                 FLOATING EXT
Forth-94: FLOOR                             FLOATING
Forth-94: FLUSH                             BLOCK
Forth-94: FLUSH-FILE                        FILE EXT
Forth-94: FM/MOD      f-m-slash-mod         CORE
Forth-94: FMAX        f-max                 FLOATING
Forth-94: FMIN        f-min                 FLOATING
Forth-94: FNEGATE     f-negate              FLOATING
Forth-94: FORGET                            TOOLS EXT
Forth-94: FORTH                             SEARCH EXT
Forth-94: FORTH-WORDLIST                    SEARCH
Forth-94: FOVER       f-over                FLOATING
Forth-94: FREE                              MEMORY
Forth-94: FROT        f-rote                FLOATING
Forth-94: FROUND      f-round               FLOATING
Forth-94: FS.         f-s-dot               FLOATING EXT
Forth-94: FSIN        f-sine                FLOATING EXT
Forth-94: FSINCOS     f-sine-cos            FLOATING EXT
Forth-94: FSINH       f-cinch               FLOATING EXT
Forth-94: FSQRT       f-square-root         FLOATING EXT
Forth-94: FSWAP       f-swap                FLOATING
Forth-94: FTAN        f-tan                 FLOATING EXT
Forth-94: FTANH       f-tan-h               FLOATING EXT
Forth-94: FVARIABLE   f-variable            FLOATING
Forth-94: F~          f-proximate           FLOATING EXT

Forth-94: GET-CURRENT                       SEARCH
Forth-94: GET-ORDER                         SEARCH

Forth-94: HERE                              CORE
Forth-94: HEX                               CORE EXT
Forth-94: HOLD                              CORE

Forth-94: I                                 CORE
Forth-94: IF                                CORE
Forth-94: IMMEDIATE                         CORE
Forth-94: INCLUDE-FILE                      FILE
Forth-94: INCLUDED                          FILE
Forth-94: INVERT                            CORE

Forth-94: J                                 CORE

Forth-94: KEY                               CORE
Forth-94: KEY?        key-question          FACILITY

Forth-94: LEAVE                             CORE
Forth-94: LIST                              BLOCK EXT
Forth-94: LITERAL                           CORE
Forth-94: LOAD                              BLOCK
Forth-94: LOCALS|     locals-bar            LOCAL EXT
Forth-94: LOOP                              CORE
Forth-94: LSHIFT      l-shift               CORE

Forth-94: M*          m-star                CORE
Forth-94: M*/         m-star-slash          DOUBLE
Forth-94: M+          m-plus                DOUBLE
Forth-94: MARKER                            CORE EXT
Forth-94: MAX                               CORE
Forth-94: MIN                               CORE
Forth-94: MOD                               CORE
Forth-94: MOVE                              CORE
Forth-94: MS                                FACILITY EXT

Forth-94: NEGATE                            CORE
Forth-94: NIP                               CORE EXT

Forth-94: OF                                CORE EXT
Forth-94: ONLY                              SEARCH EXT
Forth-94: OPEN-FILE                         FILE
Forth-94: OR                                CORE
Forth-94: ORDER                             SEARCH EXT
Forth-94: OVER                              CORE

Forth-94: PAD                               CORE EXT
Forth-94: PAGE                              FACILITY
Forth-94: PARSE                             CORE EXT
Forth-94: PICK                              CORE EXT
Forth-94: POSTPONE                          CORE
Forth-94: PRECISION                         FLOATING EXT
Forth-94: PREVIOUS                          SEARCH EXT

Forth-94: QUERY                             CORE EXT
Forth-94: QUIT                              CORE

Forth-94: R/O         r-o                   FILE
Forth-94: R/W         r-w                   FILE
Forth-94: R>          r-from                CORE
Forth-94: R@          r-fetch               CORE
Forth-94: READ-FILE                         FILE
Forth-94: READ-LINE                         FILE
Forth-94: RECURSE                           CORE
Forth-94: REFILL                            CORE EXT
Forth-94: REFILL                            BLOCK EXT
Forth-94: REFILL                            FILE EXT
Forth-94: RENAME-FILE                       FILE EXT
Forth-94: REPEAT                            CORE
Forth-94: REPOSITION-FILE                   FILE
Forth-94: REPRESENT                         FLOATING
Forth-94: RESIZE                            MEMORY
Forth-94: RESIZE-FILE                       FILE
Forth-94: RESTORE-INPUT                     CORE EXT
Forth-94: ROLL                              CORE EXT
Forth-94: ROT         rote                  CORE
Forth-94: RSHIFT      r-shift               CORE

Forth-94: S"          s-quote               CORE
Forth-94: S"          s-quote               FILE
Forth-94: S>D         s-to-d                CORE
Forth-94: SAVE-BUFFERS                      BLOCK
Forth-94: SAVE-INPUT                        CORE EXT
Forth-94: SCR         s-c-r                 BLOCK EXT
Forth-94: SEARCH                            STRING
Forth-94: SEARCH-WORDLIST                   SEARCH
Forth-94: SEE                               TOOLS
Forth-94: SET-CURRENT                       SEARCH
Forth-94: SET-ORDER                         SEARCH
Forth-94: SET-PRECISION                     FLOATING EXT
Forth-94: SF!         s-f-store             FLOATING EXT
Forth-94: SF@         s-f-fetch             FLOATING EXT
Forth-94: SFALIGN     s-f-align             FLOATING EXT
Forth-94: SFALIGNED   s-f-aligned           FLOATING EXT
Forth-94: SFLOAT+     s-float-plus          FLOATING EXT
Forth-94: SFLOATS     s-floats              FLOATING EXT
Forth-94: SIGN                              CORE
Forth-94: SLITERAL                          STRING
Forth-94: SM/REM      s-m-slash-rem         CORE
Forth-94: SOURCE                            CORE
Forth-94: SOURCE-ID   source-i-d            CORE EXT
Forth-94: SOURCE-ID   source-i-d            FILE
Forth-94: SPACE                             CORE
Forth-94: SPACES                            CORE
Forth-94: SPAN                              CORE EXT
Forth-94: STATE                             CORE
Forth-94: STATE                             TOOLS EXT
Forth-94: SWAP                              CORE

Forth-94: THEN                              CORE
Forth-94: THROW                             EXCEPTION
Forth-94: THRU                              BLOCK EXT
Forth-94: TIB         t-i-b                 CORE EXT
Forth-94: TIME&DATE   time-and-date         FACILITY EXT
Forth-94: TO                                CORE EXT
Forth-94: TO                                LOCAL
Forth-94: TRUE                              CORE EXT
Forth-94: TUCK                              CORE EXT
Forth-94: TYPE                              CORE

Forth-94: U.          u-dot                 CORE
Forth-94: U.R         u-dot-r               CORE EXT
Forth-94: U<          u-less-than           CORE
Forth-94: U>          u-greater-than        CORE EXT
Forth-94: UM*         u-m-star              CORE
Forth-94: UM/MOD      u-m-slash-mod         CORE
Forth-94: UNLOOP                            CORE
Forth-94: UNTIL                             CORE
Forth-94: UNUSED                            CORE EXT
Forth-94: UPDATE                            BLOCK

Forth-94: VALUE                             CORE EXT
Forth-94: VARIABLE                          CORE

Forth-94: W/O         w-o                   FILE
Forth-94: WHILE                             CORE
Forth-94: WITHIN                            CORE EXT
Forth-94: WORD                              CORE
Forth-94: WORDLIST                          SEARCH
Forth-94: WORDS                             TOOLS
Forth-94: WRITE-FILE                        FILE
Forth-94: WRITE-LINE                        FILE

Forth-94: XOR         x-or                  CORE

Forth-94: [           left-bracket          CORE
Forth-94: [']         bracket-tick          CORE
Forth-94: [CHAR]      bracket-char          CORE
Forth-94: [COMPILE]   bracket-compile       CORE EXT
Forth-94: [ELSE]      bracket-else          TOOLS EXT
Forth-94: [IF]        bracket-if            TOOLS EXT
Forth-94: [THEN]      bracket-then          TOOLS EXT

Forth-94: \           backslash             CORE EXT
Forth-94: \           backslash             BLOCK EXT

Forth-94: ]           right-bracket         CORE

bye