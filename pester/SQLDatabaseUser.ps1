function SQLDatabaseUser ($databaseUser) {
            
    $sqlResult = Invoke-Sqlcmd -Query "SELECT * FROM sys.syslogins WHERE name = '$databaseUser' " -ConnectionString "server=EDPIAIRO\EDP17;database=master;integrated security=sspi;"
        
    if ($sqlResult -ne $null){
    
        $true
                
    }
    else {
        $false
    }

}
