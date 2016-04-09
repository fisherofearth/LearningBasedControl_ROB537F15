function [ optimalPath, rec_minCost, computationTime ] = SBeamSearch( dist_C2C, num_city, limit, K )
%SBEAMSEARCH Summary of this function goes here
%   Detailed explanation goes here

    minCost = 1e+100;
    tic
    % Step 1.
    % start from k random state
    path = [];
    costT = [];
    for k = 1 : K
        path(:,k) = randperm(num_city)'; % randomly generate k state
        costT(k) = ObjectF( dist_C2C, path(:,k));
    end
    
    
    
    for time = 1 : limit
        % Step 2.
        % generate all successor states
       
        
        for k = 1 : K
            neighb_path = [];
            neighb_cost = [];
            for i = 1 : num_city %pick out each node
                pathShink = path(:,k);
                nodePicked = pathShink(i);
                pathShink(i) = [];
                for c = 1 : num_city %move to every gap
                    idx = ((i-1) * num_city) + c;
                    neighb_path(:,idx) = [pathShink(1:c-1); nodePicked; pathShink(c:end)];
                    neighb_cost(idx) = ObjectF( dist_C2C, neighb_path(:,idx));
                end
            end
            
%             neighbProb = neighb_cost / sum(neighb_cost); % normalization
%             neighbProb = exp(-neighbProb);
%             neighbProb = neighbProb/sum(neighbProb);
            
            % select best neighbour with prob. 
%             idx = find(rand<cumsum(neighbProb),1,'first');
%             path(:,k) = neighb_path(:,idx);
%             costT(k) =  ObjectF( dist_C2C, neighb_path(:,idx));
            
             [mi idx] = min(neighb_cost);
            path(:,k) = neighb_path(:,idx);
            costT(k) =  ObjectF( dist_C2C, neighb_path(:,idx));
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
