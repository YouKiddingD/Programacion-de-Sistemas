SUM	START	4000H
FIRST	LDX	ZERO
	LDA	ZERO
LOOP	ADD	TABLE,X
	TIX	COUNT
	JLT	LOOP
	STA	TOTAL
	RSUB
TABLE	RESW	2000
COUNT	RESW	01
ZERO	WORD	00
TOTAL	RESW	01
	END	FIRST
