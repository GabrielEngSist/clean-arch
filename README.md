# clean-arch

## N-Tier

Estrutura em camadas: 

```mermaid
graph TD
    
    Client["User/Client"] --> Presentation
    Presentation --> Client
    
    subgraph Solution
        Presentation --> BL["Business Logic"]
        BL["Business Logic"] --> DA["Data Access"]
    end

    DA --> Database
```

- Acoplamento Alto
- Simples

## Clean Architechture

```mermaid
graph TD
    Database
    Client["User/Client"] --> Presentation
    subgraph Solution
        Presentation --> Application
        Infrastructure --> Application
        Application --> Domain
    end
    Infrastructure --> Database
```

- Camada de dominio não depende das demais
- regras de negócio isoladas
- Complexidade alta
- Baixo acoplamento