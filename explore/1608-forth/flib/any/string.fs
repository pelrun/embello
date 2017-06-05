\ string.fs
\ extra string creation words
\ needs mark-resolve.fs

\ creates a zero-terminated string
: Z" ( -- addr )
  immediate
  HERE 3 + \ start address of string
  >mark
  $22 parse
  over over + 0 swap c! 1+ \ zero terminate
  string,
  >resolve
  literal,
  ;

