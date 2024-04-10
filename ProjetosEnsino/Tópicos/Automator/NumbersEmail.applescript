tell application "Numbers"
	tell table 1 of sheet 1 of document 1
    set rCount to get row count
		repeat with counter from 2 to rCount

      --Variables
      set recipientAddress to get the value of cell ("A" & counter)
      set recipientName to get the value of cell ("B" & counter)
      set theSubject to get the value of cell ("C" & counter)
      set theContent to  get the value of cell ("D" & counter)

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

		end repeat

	end tell
end tell
