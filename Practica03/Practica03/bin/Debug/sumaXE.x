SUM	START	0H
FIRST	LDX	#0
	LDA	#0
	+LDB	#TABLE2
	BASE	TABLE2
LOOP	ADD	TABLE1,X
	ADD	TABLE2,X
	TIX	COUNT
	JLT	LOOP
	RMO	A,X
	SHIFTR	A,2
	+STA	TOTAL
	CLEAR	A
COUNT	RESW	01
TABLE1	RESW	2000
TABLE2	RESW	2000
TOTAL	RESW	2000
	END		
