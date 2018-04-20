function SQLDatabaseUser ($databaseUser) {
            
    $sqlResult = Invoke-Sqlcmd -Query "SELECT * FROM sys.syslogins WHERE name = '$databaseUser' " -ConnectionString "server=EDPIAIRO\EDP17;database=master;Integrated Security=True;"
        
    if ($sqlResult -ne $null){
    
        $true
                
    }
    else {
        $false
    }

}
