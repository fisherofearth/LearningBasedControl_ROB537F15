function [ optimalPath, rec_minCost, computationTime ] = Evolutionary( dist_C2C, num_city, limit, K )
%EVOLUTIONARY Summary of this function goes here
%   Detailed explanation goes here

% K - number of initial state
    minCost = 1e+100;
    % Step 1.
    % start from k random state
    path = [];
    costT = [];
    for k = 1 : K
        path(:,k) = randperm(num_city)'; % randomly generate k state
        costT(k) = ObjectF( dist_C2C, path(:,k));
    end
    
    
    tic
    for time = 1 : limit
        % Step 2 3.
        % select best fitness and breed k new state randomly 
        [minCost idx] = min(costT);
        for k = 1 : K
            path(:,K+k) = RandInsert( path(:,idx), num_city / 5 );
            costT(K+k) = ObjectF( dist_C2C, path(:,K+k));
        end
        
        % Step 4.
        % select k states from the pool of 2K states
        for k = 1 : K
            [maxCost idx] = max(costT);
            path(:,idx) = [];
            costT(idx) = [];
        end
        
        [mi idx] = min(costT);
        rec_minCost(time) = mi;
        if(mi < minCost)
            minCost = mi;
            optimalPath = path(:,idx);
        end
    end
    optimalPath(num_city+1) = optimalPath(1);
    
    computationTime = toc;


end

