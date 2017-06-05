\ mark-resolve.fs
\ Forward and backward jumps

: >mark ( -- addr )
  HERE 2 allot
  ;

: >resolve ( addr -- )
  align
  HERE jump,
  ;

: <mark ( -- addr )
  HERE
  ;

: <resolve ( addr -- )
  HERE swap 2 allot jump,
  ;
