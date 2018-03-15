# msgpackAPI

Purpose of this repository is to implement MsgPack API (https://github.com/neuecc/MessagePack-CSharp/) not the MsgPack Cli version. 

On top of that we are trying to do :-

1. Server side / API stream of file content. Streaming model helps to reduce the memory size required. 
2. Client side that reads from a polled connection (by calling valuationsdata) writes to a file locally as data contents comes in.
3. Data that we are delivering is about 690M and to prevent connection time out or server side out of memory exception we use POST 
and returns immediately a new resource (url) that client side can poll to get the data once processing is completed. 

