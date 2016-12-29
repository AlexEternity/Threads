package main

import (
	"fmt"
	"time"
)
var n int
type Token struct
{
	recipient int
	data string
}
func message(t Token,id int) {
	if id==t.recipient {
		fmt.Println("[thread]#",id,".Recipient took message.End!")
		fmt.Println("	The message was '",t.data,"'")
	} else {
		fmt.Println("[thread]#",id,"Took...Give to the next...")
		message(t,id+1)
	}
}
func main() {
	n=100
	token := Token{recipient: n, data: "token"}
	fmt.Println("[main] Give first....")
	go message(token,1)
	time.Sleep(1000)
}