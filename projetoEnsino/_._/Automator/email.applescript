--Variables
set recipientName to "Dalton Reis"
set recipientAddress to "dalton.reis@gmail.com"
set theSubject to "AppleScript Automated Email"
set theContent to "This email was created and sent using AppleScript!"

--Mail Tell Block
tell application "Mail"
	
	--Create the message
	set theMessage to make new outgoing message with properties {subject:theSubject, content:theContent, visible:true}
	
	--Set a recipient
	tell theMessage
		make new to recipient with properties {name:recipientName, address:recipientAddress}
		
		--Send the Message 
		send
		
	end tell
end tell
