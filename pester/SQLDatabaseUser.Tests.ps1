# param(
#     [Parameter(Mandatory=$true)][string]$databaseUser,
#     [Parameter(Mandatory=$true)][string]$databasePass)


$here = Split-Path -Parent $MyInvocation.MyCommand.Path
$sut = (Split-Path -Leaf $MyInvocation.MyCommand.Path) -replace '\.Tests\.', '.'
. "$here\$sut"



Describe "SQL-Database-User" {
        
    Context "TEST"{
        It "Check if 'eduardo.piairo' exists on DevOpsPorto-Solution-db" {
            SQLDatabaseUser 'eduardo.piairo' | Should Be $true
        }
    }

    
}
